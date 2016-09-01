using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame.Fantastic
{
    public class TextBox : FantasticHelperBase
    {
        //data
        private string _cssclass;
        private IDictionary<string, string> _dicHtmlAttributes = new Dictionary<string, string>();
        private string _placeholder;
        private string _value;
        private string _name;
        //

        public TextBox Name(string name)
        {
            this._name = name;
            return this;
        }

        public TextBox Cssclass(string css)
        {
            this._cssclass = css;
            return this;
        }
        public TextBox HtmlAttributes(IDictionary<string,string> dic)
        {
            this._dicHtmlAttributes = dic;
            return this;
        }
        public TextBox PlaceHolder(string o)
        {
            this._placeholder = o;
            return this;
        }
        public TextBox Value(string val)
        {
            this._value = val;
            return this;
        }
       

        public override string Render()
        {
            this._dicHtmlAttributes.Add("id","txt_"+Guid.NewGuid().ToString("D"));
            this._dicHtmlAttributes.Add("type","text");
            this._dicHtmlAttributes.Add("class","awe-display");
            this._dicHtmlAttributes.Fill("placeholder",this._placeholder);
            this._dicHtmlAttributes.Fill("name",this._name);
            if (!string.IsNullOrEmpty(this._value))
            {
                _dicHtmlAttributes.Fill("value",this._value);
            }
            return string.Format("<input {0} />",_dicHtmlAttributes.DicToHtmlAttr());
        }
    }
}
