using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame.Fantastic
{
    public class AjaxDropDown:FantasticHelperBase
    {
        private string _id;
        private string _cssclass;
        private string _contentUrl;
        private string _name;
        private IDictionary<string, string> _dicHtmlAttributes = new Dictionary<string, string>();

        public AjaxDropDown CssClass(string cssclass)
        {
            this._cssclass = cssclass;
            return this;
        }
        public AjaxDropDown ContentUrl(string url)
        {
            this._contentUrl = url;
            return this;
        }
        public AjaxDropDown Name(string name)
        {
            this._name = name;
            return this;
        }

        public override string Render()
        {
            StringBuilder builder = new StringBuilder();
            this._id = "ul_" + Guid.NewGuid().ToString("D");
            _dicHtmlAttributes.Add("id",this._id); 
            builder.AppendFormat("<select {0}>",_dicHtmlAttributes.DicToHtmlAttr());            
            builder.Append("</select>");
            if (!string.IsNullOrEmpty(_contentUrl))
            {
                builder.Append("<script type='text/javascript'>");
                builder.Append("jQuery(function(){fan_ajaxdropdown('"+this._id+"','"+this._contentUrl+"');});");
                builder.Append("</script>");
            }
            return builder.ToString();
        }
    }
}
