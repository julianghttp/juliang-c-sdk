## ����IP SDK  -  C#

ʹ�ñ������е�API�ļ����µĹ�����ɿ��ٵ��þ���IP֧�ֵ�API�ӿ�, [�鿴����](https://visualstudio.microsoft.com/zh-hans/downloads/)

### <u>���</u>

���� - API  ����ʹ�ð���

### <u>��������</u>

1.����PCϵͳ���ذ�װ [Visual Studio 2022](https://visualstudio.microsoft.com/zh-hans/downloads/)

2.�� [����IP����](https://www.juliangip.com/) ������Ӧ�Ĳ�Ʒ

3.��ȡ���򶩵���[trade_no(ҵ���)](http://www.juliangip.com/users/product/time) �Ͷ�Ӧ�� [Key(ҵ����Կ)](http://www.juliangip.com/users/product/quantity)

### <u>[API����](https://gitee.com/juliangip/juliang-c-sdk/tree/master/examples/api) </u>

[UrlUtils.cs](https://gitee.com/juliangip/juliang-c-sdk/blob/master/examples/api/UrlUtils.cs)

ʹ�� System.Security.Cryptography �� System.Collections ��API����ӿ����ӽ���ö�ٷ�װ�Լ��ṩ������������д�����ܵķ���. 

[HttpRequest.cs](https://gitee.com/juliangip/juliang-c-sdk/blob/master/examples/api/HttpRequest.cs)

��Ҫʹ�� System.Net �� Sytem.IO �Դ���������URL������������д����;����API����,��ͨ��Stream�����յ����غ��������Ϊ����ֵ,�������ṩGET��POST����ķ���,�ɸ����Լ�������ͨ��method��������ѡ��;

<u>[client.cs](https://gitee.com/juliangip/juliang-c-sdk/blob/master/examples/api/client.cs)</u>

Client����Ҫ�����˶�API����ľ����װ,�����ӿھ��ж�Ӧ�����󷽷�,���д���������Ĳ�����Ϊ�������,���ֽӿ��ṩ�����ѡ����,�ɸ���ʵ������ʹ��Dictionary<string,string> ��ֵ�ֵ����ʽ���ݿ�ѡ����.

### <u>������ʾ����</u>

[Program.cs](https://gitee.com/juliangip/juliang-c-sdk/blob/master/examples/Program.cs)

Program������ʹ��client�����API����ϸ����,�ɲο���������ʹ��.

### <u>�ο�����</u>

- [��Ʒ�ĵ�](http://www.juliangip.com/help/product/dynamic/)
- [��������](http://www.juliangip.com/help/apply/rm/)
- [API�ӿ�](http://www.juliangip.com/help/api/api/)
- [������ָ��](http://www.juliangip.com/help/dev/dev/)







