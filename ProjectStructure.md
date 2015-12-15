# Unity重要路径
- Resources
	- Resources文件夹下的资源无论使用与否都会被打包
	- 资源会被压缩，转化成二进制
	- 打包后文件夹下的资源只读
	- 使用Resource.Load加载
	
- StreamingAssets
	- 流数据的缓存目录
	- StreamingAssets文件夹下的资源无论使用与否都会被打包
	- 资源不会被压缩和加密
	- 打包后文件夹下的资源只读，主要存放二进制文件
	- WWW类加载(一般用CreateFromFile)

- Application.persistentDataPath(可读写)

