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
        private string _cssclass = string.Empty;  
        private string _linkurl = string.Empty;
        private string _text = string.Empty;
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
        public Link LinkUrl(string linkurl)
        {
            this._linkurl = linkurl;
            return this;
        }
        public Link Text(string text)
        {
            this._text = text;
            return this;
        }

        public override string Render()
        {
            if (string.IsNullOrEmpty(this._id))
            {
                this._id = "a_" + Guid.NewGuid().ToString("D"); //唯一ID的生成               
            }
            _dicHtmlAttributes.Add("id", this._id);                    
            _dicHtmlAttributes.Fill("class", _cssclass);
            _dicHtmlAttributes.Fill("href",_linkurl);        
            return string.Format("<a {0}><b>{1}</b></a>", _dicHtmlAttributes.DicToHtmlAttr(),this._text);
        }
    }
}
