"""
This script automates code changes required to build ScottPlot in VS2019.
Run this script without arguments for usage information.

Using the script:
The python script does the steps which else have to be done manually automatically. The script takes the following arguments: 
-Repository "PATH_TO_REPOSITORY": Folder from which for .csproj and .cs files are searched for and adapted
-TargetFramework "net472": Changes the <TargetFramework> content of each found .csproj file to net472 (net462 for example selects .NET Framework 4.6.2)
-LangVersion "9.0": Changes the <LangVersion> content of each found .csproj file to 9.0
-ReplaceNamespace: Enables the replacement of the namespace ScottPlot.x; with namespace ScottPlot.x {…}in all found .cs files 
"""

import os
import sys
import re


def ParseArguments(args):
    pathRepository = ""
    targetFramework = ""
    langVersion = ""
    replaceNamespace = False

    for i in range(len(args)):
        currentArgument = args[i]
        if (sys.argv[i] == "-Repository"):
            pathRepository = sys.argv[i+1]
            i += 1
        if (sys.argv[i] == "-TargetFramework"):
            targetFramework = sys.argv[i+1]
            i += 1
        if (sys.argv[i] == "-LangVersion"):
            langVersion = sys.argv[i+1]
            i += 1
        if (sys.argv[i] == "-ReplaceNamespace"):
            replaceNamespace = True

    return [pathRepository, targetFramework, langVersion, replaceNamespace]


def GetAllProjectFiles(path):
    projectFiles = []
    if (os.path.isdir(path) == True):
        for path, subdirs, files in os.walk(path):
            for file in files:
                if (file.endswith(".csproj")):
                    projectFiles.append(os.path.join(path, file))
    return projectFiles


def GetAllSourceFiles(path):
    sourceFiles = []
    if (os.path.isdir(path) == True):
        for path, subdirs, files in os.walk(path):
            for file in files:
                if (file.endswith(".cs")):
                    sourceFiles.append(os.path.join(path, file))
    return sourceFiles


def ReplaceTargetFramework(filedata, target):
    filedata = re.sub('<TargetFrameworks>(.*)<\/TargetFrameworks>',
                      "<TargetFrameworks>" + target + "</TargetFrameworks>", filedata)
    filedata = re.sub('<TargetFramework>(.*)<\/TargetFramework>',
                      "<TargetFramework>" + target + "</TargetFramework>", filedata)
    return filedata


def ReplaceLangVersion(filedata, version):
    filedata = re.sub('<LangVersion>(.*)<\/LangVersion>',
                      "<LangVersion>" + version + "</LangVersion>", filedata)
    return filedata


def main(arguments):
    pathRepository, targetFramework, langVersion, replaceNamespace = ParseArguments(
        sys.argv)
    print("Repository: \"" + pathRepository + "\"")
    print("TargetFramework: \"" + targetFramework + "\"")
    print("LangVersion: \"" + langVersion + "\"")

    projectFiles = GetAllProjectFiles(pathRepository)

    # Actual replacement
    for projectFile in projectFiles:
        # Read in the file
        with open(projectFile, 'r') as file:
            filedata = file.read()

        # Change the TargetFramework if wanted
        if (targetFramework != ""):
            filedata = ReplaceTargetFramework(filedata, targetFramework)

        # Change the LangVersion if wanted
        if (langVersion != ""):
            filedata = ReplaceLangVersion(filedata, langVersion)

        # Write the file out again
        with open(projectFile, 'w') as file:
            file.write(filedata)

    # Replace "namespace ScottPlot.x;" with "namespace ScottPlot.x {...}" ?
    if (replaceNamespace == True):
        # Yes, so search for all source files
        sourceFiles = GetAllSourceFiles(pathRepository)
        regExpression = re.compile(r'namespace ScottPlot(.*);\n')

        # Go through all found source files
        for sourceFile in sourceFiles:
            # Expect the current file not to be changed
            writeFile = False
            with open(sourceFile, 'r') as file:
                filedata = file.read()

                # Does this file contain the said "namespace ScottPlot.x;" pattern?
                if regExpression.search(filedata):
                    # Yes it does, replace the temporary data with "namespace ScottPlot.x {...}"...
                    filedata = re.sub(
                        r'namespace ScottPlot(.*);\n', r"namespace ScottPlot\g<1>\n{\n", filedata)
                    filedata = filedata + "\n}"
                    # ... and mark the file to be written again
                    writeFile = True

            # Only write the file if there was a change
            if (writeFile == True):
                with open(sourceFile, 'w') as file:
                    file.write(filedata)


if __name__ == "__main__":
    if (len(sys.argv) == 1):
        print("""Usage:

    -Repository \"PATH\" (mandatory)
    Path to the ScottPlot repository. Absolute recommended.

    -TargetFramework \"TARGET\" (mandatory)
    Replaces the \"TargetFramework\" and \"TargetFrameworks\" tags
    with the given TARGET. For example \"net472\".

    -LangVersion \"VERSION\" (optional, but recommended)
    Replaces the \"LangVersion\" tags
    with the given VERSION. For example \"9.0\", in order to
    use \"Target-typed New Expressions\"

    -ReplaceNamespace (optional)
    Replaces the ScottPlot file scoped namespaces with curly bracets. For example
    \"namespace ScottPlot.Plottable;\" becomes \"namespace ScottPlot.Plottable {...}\"
    """)
    else:
        main(sys.argv)
