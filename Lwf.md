ruby /Users/panwei/work/lwf/source/tools/swf2lwf/swf2lwf.rb Fog.swf

/Applications/TexturePacker.app/Contents/MacOS/TexturePacker --force-squared --size-constraints AnySize --max-size 3000 --format json --data Fog.json --sheet "Fog_atlas.png" Fog.lwfdata/*.png

ruby /Users/panwei/work/lwf/source/tools/swf2lwf/swf2lwf.rb Fog.swf Fog.json 

- 第一步其实就是转成lwf格式了，但是是一堆位图。
- 第二步是调用texture packer打包成一张图和对应的json文件。
- 第三步就是根据json文件重新转成lwf