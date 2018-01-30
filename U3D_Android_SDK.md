# Unity接各家Android SDK
- 在unity的安装目录下找到一个classes.jar文件,复制到Android工程下的libs文件夹中
- 在Android中的主Activity要继承自UnityPlayerActivity
- **Android**调用**unity**的代码

```C#  
	UnityPlayer.UnitySendMessage("GameObject","FunctionName",param);
```

- 在project/bin/classes下运行 **jar -cvf** *myclass.jar* com
- 将打出的jar包放到Assets/Android/bin目录下
- Unity中被andorid调用的方法，不能写成static静态方法
- **Unity**调用**Android**

```C#
   AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
   AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
   // 可以传参数，参数类型是params[]
   // 像这样就可以了 jo.Call("u3dCallHideBanner"，参数1，参数2，参数3);
   jo.Call("u3dCallHideBanner");
```

- [Ref/Unity Android交互过坑指南](http://www.cnblogs.com/coldcode/p/4763359.html)


