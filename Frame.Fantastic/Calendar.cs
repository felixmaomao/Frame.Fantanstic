using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame.Fantastic
{
    public class Calendar:FantasticHelperBase
    {
        private string _id;
        private string _name;
        private string _cssclass;
        private TextBox _textbox = new TextBox(); //日期是需要有输入框的 
        private IDictionary<string, string> _dicHtmlAttributes = new Dictionary<string, string>();

        public Calendar ID(string id)
        {
            this._id = id;
            return this;
        }
        public Calendar Name(string name)
        {
            this._name = name;
            return this;
        }

        public override string Render()
        {
            if (string.IsNullOrEmpty(this._id))
            {
                this._id = "calendar_"+Guid.NewGuid().ToString("D");
            }
            _dicHtmlAttributes.Add("name",this._name);
           
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("<div {0}{1}></div>","id="+this._id,_dicHtmlAttributes.DicToHtmlAttr());
            builder.Append("<script type=\"text/javascript\">");
            builder.AppendFormat("$(\"#{0}\").datepicker();",this._id);
            builder.Append("</script>");
            return builder.ToString();
        }
    }
}
