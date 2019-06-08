# ColortexForms
Improving original [Colortex](https://github.com/IgorZyktin/Colortex) python project by adding WPF .NET desktop user interface for image editing.  
Text-on-image rendering algorithm is based on python scripts with callings from C# code.
## Getting Started
- Copy your images to **prepare** folder
- Launch ColortexForms.exe
- Set python interpretator path if needed (loads from **config.txt** file automatically)
- Click "Save config" if you want to change python path for auto-launch
- Select source image, click **Resize** button (if you want to lower resolution)
- Click **Convert selected**, then **Refresh** button to show up files
## Folders:
- **prepare** - source files. Accepted types: bmp, png, jpg and gif
- **input** - temporary folder for python script working
- **output** - converted files, saved as "png" or "gif"
- **used** - source files that were previously processed
---
![Demo Animation](/img/Preview.gif?raw=true)
![Demo Animation](/img/1.jpg?raw=true)
![Demo Animation](/img/2.png?raw=true)
![Demo Animation](/img/3.png?raw=true)
![Demo Animation](/img/4.png?raw=true)
![Demo Animation](/img/5.jpg?raw=true)
![Demo Animation](/img/6.png?raw=true)
![Demo Animation](/img/7.png?raw=true)
![Demo Animation](/img/8.png?raw=true)
