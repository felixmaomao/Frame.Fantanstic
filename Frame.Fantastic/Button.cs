using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame.Fantastic
{
    public class Button : FantasticHelperBase
    {
        private string _id;
        private string _cssclass;
        private string _text;
        private BTNClickActionType _actiontype=BTNClickActionType.None;
        private string _actionurl;
        private string _name;
        private IDictionary<string, string> _dicHtmlAttributes = new Dictionary<string, string>();

        public Button CssClass(string cssclass)
        {
            this._cssclass = cssclass;
            return this;
        }
        public Button Text(string text)
        {
            this._text = text;
            return this;
        }
        public Button ID(string id)
        {
            this._id = id;
            return this;
        }
        public Button Name(string name)
        {
            this._name = name;
            return this;
        }
        public Button ClickAction(BTNClickActionType actiontype,string action)
        {
            this._actiontype = actiontype;
            this._actionurl = action;
            return this;
        }
        public override string Render()
        {
            _dicHtmlAttributes.Add("id", this._id);
            _dicHtmlAttributes.Add("type", "button");
            _dicHtmlAttributes.Fill("class", _cssclass);
            _dicHtmlAttributes.Fill("value", this._text);

            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("<input {0} ", _dicHtmlAttributes.DicToHtmlAttr());
            if (this._actiontype==BTNClickActionType.Search)
            {
                builder.AppendFormat("onclick=\"Nav.SearchContent('{0}')\"", "http://localhost:2036" + this._actionurl);
            }
            if (this._actiontype==BTNClickActionType.Delete)
            {
                builder.AppendFormat("onclick=\"Nav.DeleteContent('{0}')\"", "http://localhost:2036" + this._actionurl);
            }
            builder.Append("/>");
            return builder.ToString();
        }
    }

    public enum BTNClickActionType
    {
        None,
        Search,
        Edit,
        Delete
    }

}
