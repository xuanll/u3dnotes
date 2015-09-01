[Soomla](https://github.com/soomla/unity3d-store)
>This project is a part of The SOOMLA Framework, which is a series of open source initiatives with a joint goal to help mobile game developers do more together. SOOMLA encourages better game design, economy modeling, social engagement, and faster development.

## 沙箱测试：
1. 退出测试机所登Apple账户
2. 使用Soomla的  
`Soomla.Store.StoreInventory.BuyItem(itemId, payload);
   onMarketPurchase(PurchasableVirtualItem pvi, string payload, Dictionary<string, string> extra)
`
	//payload是购买成功后返回的string，购买成功的逻辑写在*onMarketPurchase*方法中