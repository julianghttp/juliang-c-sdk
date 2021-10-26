using System;
using System.Text;
using System.Net;
using System.IO;
using System.IO.Compression;


namespace API{
    class RequestApi{


        public static string Request(string url,string param,string method = "POST"){
            string respone = "";
            HttpWebRequest httpRequest ;
            try{
                //创建HttpWebRequest对象
                if(String.Equals(method,"GET")){
                     httpRequest =(HttpWebRequest)WebRequest.Create(url+"?"+param);
                }else{
                    httpRequest = (HttpWebRequest)WebRequest.Create(url);
                }
                //设置POST类型为POST请求
                httpRequest.Method = method;
                Console.WriteLine(method);
                //设置Http头ContentType
                httpRequest.ContentType = "application/x-www-form-urlencoded;charset=utf-8";
                //如果是POST请求,使用流处理请求参数
                if(String.Equals(method,"POST")){
                    //调用内容
                    byte[] bytes = Encoding.UTF8.GetBytes(param.ToString());
                    //设置请求内容长度
                    httpRequest.ContentLength = param.ToString().Length;
                    using(Stream req = httpRequest.GetRequestStream()){
                    req.Write(bytes,0,bytes.Length);
                    req.Flush();
                    }
                }
                using(HttpWebResponse resp =(HttpWebResponse) httpRequest.GetResponse()){
                    //StreamReader对象
                    StreamReader result =  new StreamReader(resp.GetResponseStream(),Encoding.UTF8);
                    //返回结果
                    respone = result.ReadToEnd();
                    Console.WriteLine("返回结果:"+ respone);
                }

            }catch(Exception e){
                Console.WriteLine(e.StackTrace);
                respone =e+"";
            }
                return respone;

        }


        public static string GetRequest(string url,string param){
            string respone = "";
            HttpWebRequest httpRequest;
            try{
                //创建HttpWebRequest对象
                httpRequest = (HttpWebRequest)WebRequest.Create(url+"?"+param);
                //设置POST类型为POST请求
                httpRequest.Method = "GET";
                //设置Http头ContentType
                httpRequest.ContentType = "application/x-www-form-urlencoded;charset=utf-8";
                using(HttpWebResponse resp =(HttpWebResponse) httpRequest.GetResponse()){
                    //StreamReader对象
                    StreamReader result =  new StreamReader(resp.GetResponseStream(),Encoding.UTF8);
                    //返回结果
                    respone = result.ReadToEnd();
                    Console.WriteLine("返回结果:"+ respone);
                }

            }catch(Exception e){
                respone = e+"";
                Console.WriteLine(e.StackTrace);
            }
                return respone;

        }



        public static string PostRequest(string url,string param,string method = "POST"){
            string respone = "";
            HttpWebRequest httpRequest;
            try{
                //创建HttpWebRequest对象
                httpRequest = (HttpWebRequest)WebRequest.Create(url);
                //设置POST类型为POST请求
                httpRequest.Method = "POST";
                //设置Http头ContentType
                httpRequest.ContentType = "application/x-www-form-urlencoded;charset=utf-8";
                //调用内容
                byte[] bytes = Encoding.UTF8.GetBytes(param.ToString());
                //设置请求内容长度
                httpRequest.ContentLength = param.ToString().Length;
                using(Stream req = httpRequest.GetRequestStream()){
                    req.Write(bytes,0,bytes.Length);
                    req.Flush();
                }
                using(HttpWebResponse resp =(HttpWebResponse) httpRequest.GetResponse()){
                    //StreamReader对象
                    StreamReader result =  new StreamReader(resp.GetResponseStream(),Encoding.UTF8);
                    //返回结果
                    respone = result.ReadToEnd();
                    Console.WriteLine("返回结果:"+ respone);
                }

            }catch(Exception e){
                respone = e+"";
                Console.WriteLine(e.StackTrace);
            }
                return respone;

        }

    }
}