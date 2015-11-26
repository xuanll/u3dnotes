[Soomla](https://github.com/soomla/unity3d-store)
>This project is a part of The SOOMLA Framework, which is a series of open source initiatives with a joint goal to help mobile game developers do more together. SOOMLA encourages better game design, economy modeling, social engagement, and faster development.

## 沙箱测试：
1. 退出测试机所登Apple账户！！！
2. [Soomla]  
```C#
  Soomla.Store.StoreInventory.BuyItem(itemId, payload);
  onMarketPurchase(PurchasableVirtualItem pvi, string payload, Dictionary<string, string> extra);
```  
> payload是购买成功后返回的string，购买成功后的游戏逻辑写在*onMarketPurchase*方法中

```C#
      SoomlaStore.Initialize(new IOSAppStoreAssets());
            //通过Soomla发起支付
			StoreEvents.OnMarketPurchaseStarted += onMarketPurchaseStarted;
			
			 //通过Soomla支付成功
			StoreEvents.OnMarketPurchase += onMarketPurchase;
			
			 //通过Soomla取消支付
			StoreEvents.OnMarketPurchaseCancelled += onMarketPurchaseCancelled;
		
			
	public void onMarketPurchaseStarted(PurchasableVirtualItem pvi) {
	// pvi - the PurchasableVirtualItem whose purchase operation has just started
	
	// ... your game specific implementation here ...
		
	}

	public void onMarketPurchase(PurchasableVirtualItem pvi, string payload, Dictionary<string, string> extra) {
		// pvi is the PurchasableVirtualItem that was just purchased
		// payload is a text that you can give when you initiate the purchase operation and you want to receive back upon completion
		// extra will contain platform specific information about the market purchase.
		//      Android: The "extra" dictionary will contain "orderId" and "purchaseToken".
		//      iOS: The "extra" dictionary will contain "receipt" and "token".
		
		// ... your game specific implementation here ...

	}

	public void onMarketPurchaseCancelled(PurchasableVirtualItem pvi) {
		// pvi - the PurchasableVirtualItem whose purchase operation was cancelled
		
		// ... your game specific implementation here ...
	}
```
