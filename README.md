## 巨量IP SDK  -  C#

使用本案例中的API文件夹下的工具类可快速调用巨量IP支持的API接口, [查看详情](https://visualstudio.microsoft.com/zh-hans/downloads/)

### <u>简介</u>

巨量 - API  快速使用案例

### <u>依赖环境</u>

1.根据PC系统下载安装 [Visual Studio 2022](https://visualstudio.microsoft.com/zh-hans/downloads/)

2.从 [巨量IP官网](https://www.juliangip.com/) 购买相应的产品

3.获取购买订单的[trade_no(业务号)](http://www.juliangip.com/users/product/time) 和对应的 [Key(业务秘钥)](http://www.juliangip.com/users/product/quantity)

### <u>[API部分](https://gitee.com/juliangip/juliang-c-sdk/tree/master/examples/api) </u>

[UrlUtils.cs](https://gitee.com/juliangip/juliang-c-sdk/blob/master/examples/api/UrlUtils.cs)

使用 System.Security.Cryptography 和 System.Collections 对API请求接口链接进行枚举封装以及提供对请求参数进行处理加密的方法. 

[HttpRequest.cs](https://gitee.com/juliangip/juliang-c-sdk/blob/master/examples/api/HttpRequest.cs)

主要使用 System.Net 和 Sytem.IO 对处理后的请求URL和请求参数进行处理发送具体的API请求,并通过Stream流接收到返回后的数据作为返回值,该类中提供GET和POST请求的方法,可根据自己的需求通过method参数进行选择;

<u>[client.cs](https://gitee.com/juliangip/juliang-c-sdk/blob/master/examples/api/client.cs)</u>

Client类主要进行了对API请求的具体封装,各个接口均有对应的请求方法,其中大多数方法的参数均为必填参数,部分接口提供多个可选参数,可根据实际需求使用Dictionary<string,string> 键值字典的形式传递可选参数.

### <u>案例演示部分</u>

[Program.cs](https://gitee.com/juliangip/juliang-c-sdk/blob/master/examples/Program.cs)

Program类中有使用client类进行API的详细案例,可参考案例进行使用.

### <u>参考资料</u>

- [产品文档](http://www.juliangip.com/help/product/dynamic/)
- [快速入门](http://www.juliangip.com/help/apply/rm/)
- [API接口](http://www.juliangip.com/help/api/api/)
- [开发者指南](http://www.juliangip.com/help/dev/dev/)







