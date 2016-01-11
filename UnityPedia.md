# UnityPedia
- Instantiate(_From Project MathchChapter3_)
```C#
Instantiate(prefab, pos, Quaternion.identity);
```

- [HideInInspector]
在Inspector视图中隐藏参数

- CTRL/CMD+SHIFT+F  将选中对象的局部坐标设定为窗口的的局部坐标，这个快捷键非  常有用，当我们需要摆放摄像机的时候，可以先找好视口，然后选中要摆放的摄像机对其使用该快捷键，这样摄像机就和当前的窗口有相同的朝向
- __Rotation function__
```
//Rotation function
	Quaternion rotation = go.transform.rotation;
	rotation *= Quaternion.Euler (0, 0, -90);
	go.transform.rotation = rotation;
```
- Resource.Load("xxx/xxx")中的filePath指的是Assets/Resources之后的部分
- 使用UGUI需要using UnityEngine.UI
- Asset Store上下载的资源默认保存地址。Win _C:\Users\admin\AppData\Roaming\Unity\Asset Store-5.x_, Mac ~/Library/Unity/Asset Store


