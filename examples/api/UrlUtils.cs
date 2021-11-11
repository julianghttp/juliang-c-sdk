using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;



namespace API{

	static class Endpoint{

        private static string Regoin = "https://v1.api.juliangip.com";


		internal enum url : byte{
			[Description("/users/getbalance")]
			USERS_GETBALANCE,
            [Description("/users/getAllOrders")]
            USERS_GETALLORDERS,
			DYNAMIC_GETIPS,
			[Description("/dynamic/check")]
			DYNAMIC_CHECK,
			[Description("/dynamic/setwhiteip")]
    		DYNAMIC_SETWHITEIP,
    		[Description("/dynamic/getwhiteip")]
   			DYNAMIC_GETWHITEIP,
            [Description("/dynamic/replaceWhiteIp")]
            DYNAMIC_REPLACEWHITEIP,
   			[Description("/dynamic/remain")]
    		DYNAMIC_REMAIN,
    		[Description("/dynamic/balance")]
   			DYNAMIC_BALANCE,
		    [Description("/alone/getips")]
		    ALONE_GETIPS,
		    [Description("/alone/setwhiteip")]
		    ALONE_SETWHITEIP,
    		[Description("/alone/getwhiteip")]
    		ALONE_GETWHITEIP,
            [Description("/alone/replaceWhiteIp")]
            ALONE_REPLACEWHITEIP 
		}






		public static string GetDescription(this Enum enumValue)
        {
            FieldInfo fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
            DescriptionAttribute[] attrs =
                fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            return attrs.Length > 0 ? Regoin+attrs[0].Description : Regoin+enumValue.ToString();
        }


        public static string GetParams<TK,TV>(Dictionary<TK,TV> dic)
        {   
            string str = "";
            string key = "";
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            //先对参数字典进行排序
            dic = dic.OrderBy(i => i.Key).ToDictionary(i =>i.Key,i =>i.Value);
            foreach(var obj in dic){
                Console.WriteLine($"{obj.Key.ToString()}:{obj.Value.ToString()}");
                if(obj.Key != null && String.Equals(obj.Key,"key")){
                    key = obj.Value+"";
                    continue;
                }
                if(obj.Value == null || (obj.Value+"").Trim() == ""){
                	continue;
                }
                str += obj.Key+"="+obj.Value+"&";
            }
            byte[] buffer = Encoding.Default.GetBytes(str+$"key={key}");
            byte[] somme = md5.ComputeHash(buffer);
            string sign = "";
            foreach(byte s in somme){
                sign += s.ToString("x2");
            }
            str += $"sign={sign}";
            return str;
        }

	}

}