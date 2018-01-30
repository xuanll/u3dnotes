# Tool类
- Particle包含适用于粒子系统整体缩放的脚本`ParticleScaler.cs`
- CheckJson包含检查**Json格式是否合法**的网站[JSONLint](http://jsonlint.com/)
- ReadTextFile包含Unity读取文本文件工具类`ReadFileTool.cs`及示例JSON格式文件`ISPConfig.txt`，序列化(Serializable)用于网络传输对象的`JSCISPConfig`位于`GlobalConfigration.cs`
- `DelayExcute.cs`使用协程(Coroutine)实现延迟运行的工具类

# Debug
## iOS
- 解决iOS64位下列报错时，在项目中加入位于iOSReauire目录下的`AoTtyps.cs`
```
“ExecutionEngineException: Attempting to JIT compile method ‘SometType`1<SomeValueType>:.ctor ()’ while running with –aot-only.”
```

## Android
- 连接测试机，使用Android开发环境的`adb logcat`命令带上下列参数可以查看Unity输出Log信息

```
$ adb logcat -s Unity
```

# 美术资源处理
- `Lwf.md`是是用Spine将美术用Flash制作的swf资源转化成Unity可用的lwf动画文件的命令行处理步骤

# 支付
## iOS
- `PayIssues.md`介绍了前端使用`Soomla`插件实现iOS正版内购支付的要点及注意事项

# Unity与iOS及Android交互
## iOS
- `U3D_IOS.md`总结了Unity与iOS互相调用的要点及注意事项（AoTtype）

## Android
- `U3D_Android_SDK.md`总结了Unity接Andorid SDK的一些注意事项


# UI
- `UGUI.md`收集在是用uGUI过程中的笔记（待整理完善）

# 其他
- `UnityPedia.md`收集Unity的百科等内容

