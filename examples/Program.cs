using System;
using API;
using System.Collections.Generic;

using System.Text;
using System.Net;
using System.IO;
using System.IO.Compression;


namespace examples
{
     class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
           //  Console.WriteLine(Endpoint.url.USERS_GETBALANCE.GetDescription());
           //  Console.WriteLine(Endpoint.url.DYNAMIC_GETIPS.GetDescription());

           //  //city_name=1&num=5&pt=2&result_type=json&trade_no=1135123858735679&sign=a9b0b2ac4eb38651e88acf68e8eeb8cb
           // var dics = new Dictionary<string, string>();
           //  dics.Add("key","eb9887f7421e4b71bfe040a5025b55e7");
           //  dics.Add("trade_no","1135123858735679");
           //  dics.Add("pt","2");
           //  dics.Add("num","5");
           //  dics.Add("city_name","1");
           //  dics.Add("result_type","json");
           //  // PrintDic(dics);
            
           //  string signStr = Endpoint.GetParams(dics);
           //  Console.WriteLine("xxxxxxxxxx"+signStr);
            // RequestApi css = new RequestApi();
            // RequestApi.Request(Endpoint.url.DYNAMIC_GETIPS.GetDescription(),signStr,"POST");
            // RequestApi.GetRequest(Endpoint.url.DYNAMIC_GETIPS.GetDescription(),signStr);
            // RequestApi.PostRequest(Endpoint.url.DYNAMIC_GETIPS.GetDescription(),signStr);
            Client client = new Client();

            string userId = "1000004";
            string AccessKey = "514a59cca7f5481ba4d7a817a866328c";

            // string dyTradeNo = "1135123858735679";
            // string dyKey = "eb9887f7421e4b71bfe040a5025b55e7";

            // string kpsTradeNo = "4058562701502429";
            // string kpsKey = "7cc5a5ba632744a6aaa1202ef84a82f1";


            //获取账户余额
            string  userMsg = client.UserBalance(userId,AccessKey);
            Console.WriteLine(userMsg);


            //动态代理 -- 提取代理IP
            // var otherparam = new Dictionary<string,string>();
            // otherparam.Add("pt","2");
            // otherparam.Add("city_name","1");
            // otherparam.Add("result_type","json");
            // string dynamicGetIpsResp = client.DynamicGetIps(dykey,dyTradeNo,"5",otherparam);
            // Console.WriteLine(dynamicGetIpsResp);


            //动态代理 -- 检查代理IP有效性
            // string dynamicCheckResp = client.DynamicCheck(dykey,dyTradeNo,"218.62.125.119:46991");
            //Console.WriteLine(dynamicCheckResp)

            // //动态代理 -- 设置白名单
            // string dynamicSetWhiteIpResp = client.DynamicSetWhiteIp(dykey,dyTradeNo,"2.3.3.3,66.66.33.33");
            // Console.WriteLine(dynamicSetWhiteIpResp)

            //动态代理 -- 获取白名单
            // string dynamicGetWhiteIpResp = client.DynamicGetWhiteIp(dykey,dyTradeNo);
            // Console.WriteLine(dynamicGetWhiteIpResp);

            //动态代理 -- 获取剩余可用时长
            // string dynamicRemainResp = client.DynamicRemain(dykey,dyTradeNo,"218.62.125.119:46991");
            // Console.WriteLine(dynamicRemainResp);

            //动态代理 -- 获取剩余IP数
            // string dynamicBalanceResp = client.DynamicBalance(dykey,dyTradeNo);
            // Console.WriteLine(dynamicBalanceResp);


            //独享代理 -- 获取代理详情
            // var kpsParam = new Dictionary<string,string>();
            // kpsParam.Add("pt","2");
            // kpsParam.Add("sock_port","1");
            // kpsParam.Add("city_name","1");
            // kpsParam.Add("ip_ramain","1");
            // kpsParam.Add("ordere_endtime","1");
            // string kpsGetIps = client.AloneGetIps(kpsKey,kpsTradeNo,kpsParam);
            // Console.WriteLine(kpsGetIps);

            // //独享代理 -- 设置代理IP白名单
            // string kpsSetWhiteIp = client.AloneSetWhiteIp(kpsKey,kpsTradeNo,"15.16.17.18");
            // Console.WriteLine(kpsSetWhiteIp);

            // //独享代理 -- 获取代理IP白名单
            // string kpsGetWhiteIp = client.AloneGetWhiteIp(kpsKey,kpsTradeNo);
            // Console.WriteLine(kpsGetWhiteIp);

            
        }


        
        

        

    }
}
