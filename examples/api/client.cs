using System;
using API;
using System.Collections.Generic;



namespace API{

	class Client{

		/**
		 * 获取账户可用余额
		 * @param 		userId 		用户ID
		 * @param 		AccessKey		秘钥
		 * @param 		method 		HTTP请求方式
		 * @returns		请求响应结果	
		 */
		public string UserBalance(string userId,string AccessKey,string method = "POST"){
			//1.获取访问用户余额的请求路径
			string url = Endpoint.url.USERS_GETBALANCE.GetDescription();
			//2.收集请求写携带的参数
			var param = new Dictionary<string,string>();
			param.Add("key",AccessKey);
			param.Add("user_id",userId);
			string paramsStr = Endpoint.GetParams(param);
			Console.WriteLine("Request URL : "+url+"?"+paramsStr);
			return RequestApi.Request(url,paramsStr,method);
		}

		/**
		 * 动态代理 -- 提取代理IP
		 * @param 	 	key 				业务秘钥 		<必传参数>
		 * @param 	 	trade_no  			业务号			<必传参数>
		 * @param 	 	num 				提取数量 		<必传参数>
		 * @param 	 	otherParams 		可选参数字典		<可选参数>
		 * otherParams {
		 *  pt : 代理类型,
		 *  result_type : 返回类型('text' | 'json' | 'xml')
		 *  split 		: 结果分隔符,
		 *  city_name 	: 地区名称,
		 *  city_code 	: 邮政编码,
		 *  ip_remain 	: 剩余可用时长,
		 *  area 		: 筛选地区,
		 *  no_area 	: 排除地区,
		 *  ip_seg 		: 筛选IP段,
		 *  no_ip_seg	: 排除IP段,
		 *  isp 		: 运营商筛选,
		 *  filter 		: IP去重
		 * } 
		 * @param 		method 		HTTP请求方式		<可选参数>
		 * @returns		请求响应结果	
		 */
		public string DynamicGetIps(string key,string trade_no,string num,Dictionary<string,string> otherParams = null,string method = "POST"){
			//获取动态代理提取链接的请求路径
			string url = Endpoint.url.DYNAMIC_GETIPS.GetDescription();
			//2.收集请求写携带的参数
			var param = new Dictionary<string,string>();
			param.Add("key",key);
			param.Add("trade_no",trade_no);
			param.Add("num",num);
			if(otherParams != null && otherParams.Count >0){
				foreach(var obj in otherParams){
					param.Add(obj.Key,obj.Value);
				}
			}
			string paramsStr = Endpoint.GetParams(param);
			Console.WriteLine("Request URL : "+url+"?"+paramsStr);
			return RequestApi.Request(url,paramsStr,method);

		}

		/**
		 * 动态代理 -- 校验代理IP有效性
		 * @param 	 key 			业务秘钥			<必传参数>
		 * @param  	 trade_no		业务号			<必传参数>
		 * @param  	 proxy 			代理IP列表		<必传参数>
		 * @param  	 method 		HTTP请求方式		<可选参数>
		 * @returns  请求响应结果	
		 */
		public string DynamicCheck(string key,string trade_no,string proxy,string method = "POST"){
			//1.获取 动态代理--校验代理有效性的请求路径
			string url = Endpoint.url.DYNAMIC_CHECK .GetDescription();
			//2.收集请求写携带的参数
			var param = new Dictionary<string,string>();
			param.Add("key",key);
			param.Add("trade_no",trade_no);
			param.Add("proxy",proxy);
			string paramsStr = Endpoint.GetParams(param);
			Console.WriteLine("Request URL : "+url+"?"+paramsStr);
			return RequestApi.Request(url,paramsStr,method);
		}

		/**
		 * 动态代理 -- 设置代理IP白名单
		 * @param 		key 		业务秘钥				<必传参数>
		 * @param 		trade_no 	业务号				<必传参数>
		 * @param 		ips 		需要设置的白名单IP	<必传参数>
		 * @param 		method 		HTTP请求类型			<可选参数>
		 * @returns 	请求响应结果	
		 */
		public string DynamicSetWhiteIp(string key,string trade_no,string ips,string method = "POST"){
			//1.获取 动态代理 -- 设置白名单的请求路径
			string url = Endpoint.url.DYNAMIC_SETWHITEIP.GetDescription();
			//2.收集请求传递的参数
			var param = new Dictionary<string,string>();
			param.Add("key",key);
			param.Add("trade_no",trade_no);
			param.Add("ips",ips);
			string paramsStr = Endpoint.GetParams(param);
			Console.WriteLine("Request URL : "+url+"?"+paramsStr);
			return RequestApi.Request(url,paramsStr,method);
		}

		/**
		 * 动态代理 -- 获取IP白名单
		 * @param 		key 		业务秘钥			<必传参数>
		 * @param 		trade_no 	业务号			<必传参数>
		 * @param 		method 		HTTP请求类型		<可选参数>
		 * @returns 	请求响应结果	
		 */
		public string DynamicGetWhiteIp(string key,string trade_no,string method = "POST"){
			//1.获取 动态代理-- 获取白名单的请求路径
			string url = Endpoint.url.DYNAMIC_GETWHITEIP.GetDescription();
			//2.收集请求传递的参数
			var param = new Dictionary<string,string>();
			param.Add("key",key);
			param.Add("trade_no",trade_no);
			string paramsStr = Endpoint.GetParams(param);
			Console.WriteLine("Request URL : "+url+"?"+paramsStr);
			return RequestApi.Request(url,paramsStr,method);
		}

		/**
		 * 动态代理 -- 获取IP剩余可用时长
		 * @param 		key 		业务秘钥			<必传参数>
		 * @param 		trade_no 	业务号			<必传参数>
		 * @param 		method 		HTTP请求类型		<可选参数>
		 * @returns 	请求响应结果	
		 */
		public string DynamicRemain(string key,string trade_no,string proxy,string method = "POST"){
			//1.获取 动态代理 -- 剩余可用时长的请求路径
			string url = Endpoint.url.DYNAMIC_REMAIN.GetDescription();
			//2.收集请求传递的参数
			var param = new Dictionary<string,string>();
			param.Add("key",key);
			param.Add("trade_no",trade_no);
			param.Add("proxy",proxy);
			string paramsStr = Endpoint.GetParams(param);
			Console.WriteLine("Request URL : "+url+"?"+paramsStr);
			return RequestApi.Request(url,paramsStr,method);
		}

		/**
		 * 动态代理 -- 获取剩余可提取IP数
		 * @param 		key 		业务秘钥			<必传参数>
		 * @param 		trade_no 	业务号			<必传参数>
		 * @param 		method 		HTTP请求类型		<可选参数>
		 * @returns 	请求响应结果	
		 */
		public string DynamicBalance(string key,string trade_no,string method = "POST"){
			//1.获取 动态代理 -- 剩余可提取IP数的请求路径
			string url = Endpoint.url.DYNAMIC_BALANCE.GetDescription();
			//2.收集请求传递的参数
			var param = new Dictionary<string,string>();
			param.Add("key",key);
			param.Add("trade_no",trade_no);
			string paramsStr = Endpoint.GetParams(param);
			Console.WriteLine("Request URL : "+url+"?"+paramsStr);
			return RequestApi.Request(url,paramsStr,method);

		}


		/**
		 * 独享代理 -- 获取代理详情
		 * @param  		key 			业务秘钥		<必传参数>
		 * @param  		trade_no 		业务号		<必传参数>
		 * @param 	 	otherParams 	可选参数字典	<可选参数>
		 * otherParams {
		 *    sock_port 		: Sock代理端口,
		 *    city_name 		: 地区名称,
		 *    city_code 		: 邮政编码,
		 *    ip_remain 		: IP可用时长(动态型独有)
		 *    order_endtime 	: 业务到期时间
		 * }
		 * @param 		method 		HTTP请求方式		<可选参数>
		 * @returns		请求响应结果	
		 */
		public string AloneGetIps(string key,string trade_no,Dictionary<string,string> otherParams,string method = "POST"){
			//1.获取 独享代理 -- 获取独享代理详情的请求路径
			string url = Endpoint.url.ALONE_GETIPS.GetDescription();
			//2.收集请求传递的参数
			var param = new Dictionary<string,string>();
			param.Add("key",key);
			param.Add("trade_no",trade_no);
			if(otherParams != null && otherParams.Count >0){
				foreach(var obj in otherParams){
					param.Add(obj.Key,obj.Value);
				}
			}
			string paramsStr = Endpoint.GetParams(param);
			Console.WriteLine("Request URL : "+url+"?"+paramsStr);
			return RequestApi.Request(url,paramsStr,method);
		}

		/**
		 * 动态代理 -- 设置代理IP白名单
		 * @param 		key 		业务秘钥				<必传参数>
		 * @param 		trade_no 	业务号				<必传参数>
		 * @param 		ips 		需要设置的白名单IP	<必传参数>
		 * @param 		method 		HTTP请求类型			<可选参数>
		 * @returns 	请求响应结果	
		 */
		public string AloneSetWhiteIp(string key,string trade_no,string ips,string method = "POST"){
			//1.获取 独享代理 -- 设置代理IP白名单的请求路径
			string url = Endpoint.url.ALONE_SETWHITEIP.GetDescription();
			//2.收集请求传递的参数
			var param = new Dictionary<string,string>();
			param.Add("key",key);
			param.Add("trade_no",trade_no);
			param.Add("ips",ips);
			string paramsStr = Endpoint.GetParams(param);
			Console.WriteLine("Request URL : "+url+"?"+paramsStr);
			return RequestApi.Request(url,paramsStr,method);
		}

		/**
		 * 动态代理 -- 设置代理IP白名单
		 * @param 		key 		业务秘钥				<必传参数>
		 * @param 		trade_no 	业务号				<必传参数>
		 * @param 		method 		HTTP请求类型			<可选参数>
		 * @returns 	请求响应结果	
		 */
		public string AloneGetWhiteIp(string key,string trade_no,string method = "POST"){
			//1.获取 独享代理 -- 获取代理IP白名单的请求路径
			string url = Endpoint.url.ALONE_GETWHITEIP.GetDescription();
			var param = new Dictionary<string,string>();
			param.Add("key",key);
			param.Add("trade_no",trade_no);
			string paramsStr = Endpoint.GetParams(param);
			Console.WriteLine("Request URL : "+url+"?"+paramsStr);
			return RequestApi.Request(url,paramsStr,method);
		}





	}

}