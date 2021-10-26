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

		private static string Regoin = "http://192.168.10.60:8087";

		internal enum url : byte{
			[Description("/v1/users/getbalance")]
			USERS_GETBALANCE,
			[Description("/v1/dynamic/getips")]
			DYNAMIC_GETIPS,
			[Description("/v1/dynamic/check")]
			DYNAMIC_CHECK,
			[Description("/v1/dynamic/setwhiteip")]
    		DYNAMIC_SETWHITEIP,
    		[Description("/v1/dynamic/getwhiteip")]
   			DYNAMIC_GETWHITEIP,
   			[Description("/v1/dynamic/remain")]
    		DYNAMIC_REMAIN,
    		[Description("/v1/dynamic/balance")]
   			DYNAMIC_BALANCE,
		    [Description("/v1/alone/getips")]
		    ALONE_GETIPS,
		    [Description("/v1/alone/setwhiteip")]
		    ALONE_SETWHITEIP,
    		[Description("/v1/alone/getwhiteip")]
    		ALONE_GETWHITEIP 
		}


		public static string GetDescription(this Enum enumValue)
        {
            FieldInfo fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
            DescriptionAttribute[] attrs =
                fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            return attrs.Length > 0 ? Regoin+attrs[0].Description : enumValue.ToString();
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