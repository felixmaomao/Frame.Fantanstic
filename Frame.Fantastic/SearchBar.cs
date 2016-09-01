using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace Frame.Fantastic
{
    public class SearchBar : FantasticHelperBase
    {
        private string _searchUrl = string.Empty;
        private string _id;
        private string _cssclass;
        private IEnumerable<SearchItem> _searchItems = new List<SearchItem>();
        private IDictionary<string, string> _dicHtmlAttributes = new Dictionary<string, string>();

        public SearchBar SearchUrl(string url)
        {
            this._searchUrl = url;
            return this;
        }

        public SearchBar CssClass(string cssclass)
        {
            this._cssclass = cssclass;
            return this;
        }

        public SearchBar SearchItems(params SearchItem[] items)
        {
            this._searchItems = items;
            return this;
        }

        public override string Render()
        {
            StringBuilder builder = new StringBuilder();
            if (!string.IsNullOrEmpty(this._cssclass))
            {
                _dicHtmlAttributes.Fill("class", _cssclass);
            }
            this._id = "search_toolbar_" + Guid.NewGuid().ToString("D");
            builder.Append("<form name='form_searchbar' id='form_searchbar' method='post'>");
            builder.Append(string.Format("<div {0}{1}>", "id='" + this._id + "' ", _dicHtmlAttributes.DicToHtmlAttr()));
            if (this._searchItems.Count() > 0)
            {
                foreach (var item in _searchItems)
                {
                    builder.Append(item.Render());
                }
            }
            builder.Append(new Button().CssClass("btn btn-default").ClickAction(BTNClickActionType.Search,this._searchUrl).Text("检索").Render());
            builder.Append("</div>");
            builder.Append("</form>");
            return builder.ToString();
        }
    }

    public class SearchItem : FantasticHelperBase
    {
        private string _name;
        private string _id;
        private string _searchText;        
        private SearchType _searchType;
        private string _value;
        private string _contentUrl=string.Empty;

        public SearchItem Name(string name)
        {
            this._name = name;
            return this;
        }

        public SearchItem ID(string ID)
        {
            this._id = ID;
            return this;
        }

        public SearchItem Value(string value)
        {
            this._value = value;
            return this;
        }

        public  SearchItem SearchText(string text)
        {
            this._searchText = text;
            return this;
        }
        public SearchItem SearchType(SearchType type)
        {
            this._searchType = type;
            return this;
        }

        public SearchItem ContentUrl(string contentUrl)
        {
            this._contentUrl = contentUrl;
            return this;
        }
        public override string Render()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("<span>{0}</span>", this._searchText);
            switch (this._searchType)
            {
                case Fantastic.SearchType.Text:
                    builder.Append(new TextBox().Name(this._name).Value(this._value));   
                    break;
                case Fantastic.SearchType.Calendar:
                    builder.Append(new Calendar().Name(this._name));
                    break;
                case Fantastic.SearchType.DropDown:
                    builder.Append(new AjaxDropDown().Name(this._name).ContentUrl(this._contentUrl));
                    break;
                default:
                    builder.Append(new TextBox().Name(this._name).Value(this._value));
                    break;
            }
            return builder.ToString();
        }
    }

    public enum SearchType
    {
        Text,
        Calendar,
        DropDown
    }



}
