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
           
            Client client = new Client();

            //用户信息 -- 用户名/用户秘钥
            string userId = "your UserID";
            string AccessKey = "your AccessKey";

            //动态代理 -- 业务编号/业务秘钥
            string dyTradeNo = "dynamic_trade_no";
            string dyKey = "dynamic_key";

            //独享代理 -- 业务编号/业务秘钥
            string kpsTradeNo = "alone_trade_no";
            string kpsKey = "alone_key";

          
            // // //获取账户余额
            string  userMsg = client.UserBalance(userId,AccessKey);
            Console.WriteLine(userMsg);

            //获取账户下对应订单类型的所有订单编号
            string orderList = client.GetAllOrders(userId,AccessKey,"4");
            Console.WriteLine(orderList);


            //动态代理 -- 提取代理IP
            var otherparam = new Dictionary<string,string>();
            otherparam.Add("pt","2");
            otherparam.Add("city_name","1");
            otherparam.Add("result_type","json");
            string dynamicGetIpsResp = client.DynamicGetIps(dykey,dyTradeNo,"5",otherparam);
            Console.WriteLine(dynamicGetIpsResp);


            //动态代理 -- 检查代理IP有效性
            string dynamicCheckResp = client.DynamicCheck(dykey,dyTradeNo,"218.62.125.119:46991");
            Console.WriteLine(dynamicCheckResp)

            //动态代理 -- 设置白名单
            string dynamicSetWhiteIpResp = client.DynamicSetWhiteIp(dykey,dyTradeNo,"2.3.3.3,66.66.33.33");
            Console.WriteLine(dynamicSetWhiteIpResp)

            //动态代理 -- 获取白名单
            string dynamicGetWhiteIpResp = client.DynamicGetWhiteIp(dykey,dyTradeNo);
            Console.WriteLine(dynamicGetWhiteIpResp);

            /**
             * 动态代理 -- 替换白名单IP
             * 1.先获取已存在的白名单
             * 2.选择需要替换的旧IP和设置新的IP
             */
            string dynamicGetWhiteIpResp = client.DynamicGetWhiteIp(dyKey,dyTradeNo);
            Console.WriteLine(dynamicGetWhiteIpResp);

            var otherQuery = new Dictionary<string,string>();
            otherQuery.Add("reset","1");
            otherQuery.Add("old_ip","1.3.3.2,5.2.1");
            string dynamicReplaceWhiteIp = client.DynamicReplaceWhiteIp(dyKey,dyTradeNo,"25.52.20.21,9.5.2.7",otherQuery);
            Console.WriteLine(dynamicReplaceWhiteIp);

            //动态代理 -- 获取剩余可用时长
            string dynamicRemainResp = client.DynamicRemain(dykey,dyTradeNo,"218.62.125.119:46991");
            Console.WriteLine(dynamicRemainResp);

            //动态代理 -- 获取剩余IP数
            string dynamicBalanceResp = client.DynamicBalance(dykey,dyTradeNo);
            Console.WriteLine(dynamicBalanceResp);


            //独享代理 -- 获取代理详情
            var kpsParam = new Dictionary<string,string>();
            kpsParam.Add("pt","2");
            kpsParam.Add("sock_port","1");
            kpsParam.Add("city_name","1");
            kpsParam.Add("ip_ramain","1");
            kpsParam.Add("ordere_endtime","1");
            string kpsGetIps = client.AloneGetIps(kpsKey,kpsTradeNo,kpsParam);
            Console.WriteLine(kpsGetIps);

            //独享代理 -- 设置代理IP白名单
            string kpsSetWhiteIp = client.AloneSetWhiteIp(kpsKey,kpsTradeNo,"15.16.17.18");
            Console.WriteLine(kpsSetWhiteIp);

            //独享代理 -- 获取代理IP白名单
            string kpsGetWhiteIp = client.AloneGetWhiteIp(kpsKey,kpsTradeNo);
            Console.WriteLine(kpsGetWhiteIp);

            /**
             * 独享代理 -- 替换白名单IP
             * 1.先获取已存在的白名单
             * 2.选择需要替换的旧IP和设置新的IP
             */
            string kpsGetWhiteIp = client.AloneGetWhiteIp(kpsKey,kpsTradeNo);
            Console.WriteLine(kpsGetWhiteIp);

            var otherQuery = new Dictionary<string,string>();
            otherQuery.Add("reset","1");
            otherQuery.Add("old_ip","11.12.13.14");
            string kpsReplaceWhiteIp = client.AloneReplaceWhiteIp(kpsKey,kpsTradeNo,"9.9.9.9",otherQuery);
            Console.WriteLine(kpsReplaceWhiteIp);




            
        }


        
        

        

    }
}
