:: banner.svg is a 1200x630 for og images
:: magick banner.svg banner.png :: export from InkScape because font issue
magick banner.png banner.jpg

:: favicon.svg is a square icon
magick favicon.svg -resize 16x16 favicon-16.png
magick favicon.svg -resize 32x32 favicon-32.png
magick favicon.svg -resize 64x64 favicon-64.png
magick favicon.svg -resize 128x128 favicon-128.png
magick favicon.svg -resize 180x180 favicon-180.png
magick favicon.svg -resize 192x192 favicon-192.png
magick favicon.svg -resize 256x256 favicon-256.png
magick favicon.svg -resize 512x512 favicon-512.png
magick favicon-32.png -colors 256 favicon-32.ico
magick favicon-16.png favicon-32.png favicon-64.png favicon-128.png favicon-256.png -colors 256 favicon.ico

copy favicon.ico ..\..\

pause