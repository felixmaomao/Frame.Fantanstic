using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame.Fantastic
{
    public class Link : FantasticHelperBase
    {
        private string _id = string.Empty;
        private string _name = string.Empty;
        private string _cssclass = string.Empty;
        private string _value = string.Empty;
        private IDictionary<string, string> _dicHtmlAttributes = new Dictionary<string, string>();

        public Link ID(string id)
        {
            this._id = id;
            return this;
        }
        public Link CssClass(string css)
        {
            this._cssclass = css;
            return this;
        }
        public Link Name(string name)
        {
            this._name = name;
            return this;
        }
        public Link Value(string value)
        {
            this._value = value;
            return this;
        }

        public override string Render()
        {
            _dicHtmlAttributes.Add("id", this._id);
            _dicHtmlAttributes.Add("type", "checkbox");
            _dicHtmlAttributes.Fill("class", _cssclass);
            _dicHtmlAttributes.Fill("value", _value);

            return string.Format("<a href= {0} />", _dicHtmlAttributes.DicToHtmlAttr());
        }
    }
}
