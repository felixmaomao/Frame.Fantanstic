using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame.Fantastic
{
    public class ButtonPopup : FantasticHelperBase
    {
        private string _id;
        private string _cssclass;
        private string _text;
        private string _contentUrl;
        private string _popupType=Frame.Fantastic.PopupType.PopupAdd;

        private IDictionary<string, string> _dicHtmlAttributes = new Dictionary<string, string>();

        public ButtonPopup ID(string id)
        {
            this._id = id;
            return this;
        }
        public ButtonPopup CssClass(string css)
        {
            this._cssclass = css;
            return this;
        }
        public ButtonPopup Text(string text)
        {
            this._text = text;
            return this;
        }
        public ButtonPopup ContentUrl(string url)
        {
            this._contentUrl = url;
            return this;
        }
        public ButtonPopup PopupType(string type)
        {
            this._popupType = type;
            return this;
        }

        public override string Render()
        {
            _dicHtmlAttributes.Add("id", this._id);
            _dicHtmlAttributes.Add("type", "button");
            _dicHtmlAttributes.Fill("class", _cssclass);
            _dicHtmlAttributes.Fill("value", this._text);
            if (!string.IsNullOrEmpty(this._contentUrl))
            {              
               _dicHtmlAttributes.Add("onclick", "fan_initpopup('" + this._contentUrl + "','" + this._popupType + "');");              
            }
            return string.Format("<input {0} />", _dicHtmlAttributes.DicToHtmlAttr());
        }
    }

    public class PopupType
    {
        public const string PopupAdd = "PopupAdd";
        public const string PopupEdit = "PopupEdit";
    }

    
}
