# Unity接iOS SDK

## Unity call iOS
- in C# file
 - using System.Runtime.InteropServices;
 - ```
   [DllImport("__Internal")]
    private static extern void Soha_Login();

    [DllImport("__Internal")]
    private static extern void Soha_Payment();
   ```
  - ```
  	public static void Login()
    {
	//#if UNITY_IOS|| UNITY_ANDROID
	#if UNITY_IOS
		//need init sdk before call this
		Soha_Login();
	#endif
    }
    ```

## XCode Project from Unity
- disable Bitcode
- enable C++ RuntimeTypes
- IOS 6.0+
- Info.plist中添加 NSAppTransportSecurity 类型 Dictionary ; 
  在 NSAppTransportSecurity 下添加 NSAllowsArbitraryLoads 类型Boolean ,值设为 YES; 
  **for https requires**
- ```
	#if defined(__cplusplus)
	extern "C" {
	#endif
	    void Soha_Login();
	    
	    void Soha_Payment();
	    
	    
	#if defined(__cplusplus)
	}
	#endif

	void Soha_Login()
	{
	    printf("Call Soha_Login()...");
	    [[SohaInterface getSohaShared] sohaLogin];
	}
  ```
 - UnityAppController
 	- @interface UnityAppController : NSObject<UIApplicationDelegate,SohaDelegate>
 	- didFinishLaunchingWithOptions中进行**SDK初始化**等操作

## iOS call Unity

- UnitySendMessage("LoginPanel", "LoginViaSoha", [user.userId UTF8String]);






