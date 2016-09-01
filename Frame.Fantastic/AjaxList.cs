using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame.Fantastic
{
    public class AjaxList:FantasticHelperBase
    {
        private string _url;
        private string _id;
        private string _cssclass;
        private IDictionary<string,string> _dicHtmlAttributes=new Dictionary<string,string>();
        public AjaxList Url(string url)
        {
            this._url = url;
            return this;
        }

        public override string Render()
        {           
            this._id = "ul_" + Guid.NewGuid().ToString("D");
            StringBuilder builder = new StringBuilder();
            builder.Append(string.Format("<ul {0} {1}></ul>","id='"+this._id+"'",_dicHtmlAttributes.DicToHtmlAttr()));
            builder.Append("<script type='text/javascript'>");
            builder.Append("jQuery(function(){fan_ajaxlist('"+this._id+"','"+this._url+"');});");
            builder.Append("</script>");
            return builder.ToString();
        }
    }
}
