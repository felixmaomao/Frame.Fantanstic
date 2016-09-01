using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame.Fantastic
{
    public class InitPopup:FantasticHelperBase
    {
        private string _id; //div弹出层的id
        private string _url;
        private string _cssclass;
        private string _name;
        private IDictionary<string, string> _dicHtmlAttributes = new Dictionary<string,string>();

        public InitPopup CssClass(string cssclass)
        {
            this._cssclass = cssclass;
            return this;
        }

        public InitPopup Url(string url)
        {
            this._url = url;
            return this;
        }

        public InitPopup Name(string name)
        {
            this._name = name;
            return this;
        }

        public override string Render()
        {
            this._id = "popup_" + Guid.NewGuid().ToString("D");
            StringBuilder builder = new StringBuilder();
            builder.Append("<script type=\"text/javascript\">");
            builder.Append("jQuery(function(){fan_initpopup('"+this._id+"','"+this._url+"','"+this._name+"')});");
            builder.Append("</script>");
            return builder.ToString();
        }
    }
}
