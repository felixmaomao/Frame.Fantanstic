using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace Frame.Fantastic
{
    public static class Extentions
    {
        public static string DicToHtmlAttr(this IDictionary<string,string> dic)
        {
            if (dic==null)
            {
                return null;
            }
           return dic.Aggregate<KeyValuePair<string, string>, string>("", (c, v) => string.Concat(new object[] { c, v.Key, "=", '"', HttpUtility.HtmlAttributeEncode(v.Value), "\" " }));
        }


        public static IDictionary<string,string> Fill(this IDictionary<string,string> dic,string key,string value)
        {
            if(!dic.ContainsKey(key)&&value!=null)
            {
                dic.Add(key,value);
            }
            return dic;
        }
    }
}
