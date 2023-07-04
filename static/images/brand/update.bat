:: The banner is a 1200x630 OpenGraph image.
:: Do not convert it to PNG using ImageMagick because font anti-aliasing issue.
:: Instead export from InkScape because ImageMagick has issues

:: create manifest images
magick -background none favicon.svg -resize 192x192 favicon-192.png
magick -background none favicon.svg -resize 512x512 favicon-512.png

:: create favicon
convert -background none favicon.svg -define icon:auto-resize=64,48,32,16 favicon.ico

copy favicon.ico ..\..\

pause