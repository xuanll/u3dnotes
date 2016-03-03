# UGUI
- UIText
	- RichText(<color=blue>New</color>, blue可换成#rrggbbaa值；<b></b>,<i></i>,<size=50>largely</size>都可用 )  

- UGUI里的Depth都在Canvas里
- UGUI里Button事件(脚本添加) 

```C#
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class ClickObject : MonoBehaviour
{
    void Start ()
    {
        //获取按钮游戏对象
        GameObject btnObj = GameObject.Find ("Canvas/Button");
        //获取按钮脚本组件
        Button btn = (Button) btnObj.GetComponent<Button>();
        //添加点击侦听
        btn.onClick.AddListener (onClick);
    }

    void onClick ()
    {
        Debug.Log ("click!");
    }
}
```

```C#
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class ClickObject2 : MonoBehaviour
{
    void Start ()
    {
        //获取按钮游戏对象
        GameObject btnObj = GameObject.Find ("Canvas/Button");
        //获取按钮脚本组件
        Button btn = (Button) btnObj.GetComponent<Button>();
        //添加点击侦听
        btn.onClick.AddListener (delegate() {
            onClick(btnObj);
        });
    }
    
    void onClick (GameObject obj)
    {
        Debug.Log ("click: " + obj.name);
    }
}
```
- Canvas
  先按order in Layer排序，然后按Plane Distance排序
  
- Slider
  Fill Area需要选择完全填充，Handle Area也是（在slider.value == 1的情况下）
  
- Image
  1. Resources.Load("GameCard/"+item.AssetName, typeof(Sprite)) as Sprite;
  2. image.overrideSprite 结合上条，动态更改image图片内容

- Canvas Group忽略点击事件
> Canvas Group组件的Blocks Raycasts属性变为false，就可以不响应点击事件，原理和collider一样的。


