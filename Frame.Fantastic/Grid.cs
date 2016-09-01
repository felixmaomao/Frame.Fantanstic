using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace Frame.Fantastic
{
    public class Grid:FantasticHelperBase
    {
        private IEnumerable<Column> _columns = new List<Column>();
        private string _cssclass= "table table-hover table-borderd";  //表格默认样式
        private string _name;
        private IDictionary<string, string> _dicHtmlAttributes = new Dictionary<string, string>();
        private string _url;
        private string _id;

        public Grid Columns(params Column[] o)
        {
            this._columns = o;
            return (Grid)this;
        }
        public Grid CssClass(string cssclass)
        {
            this._cssclass = cssclass;
            return this;
        }
        public Grid Url(string url)
        {
            this._url = url;
            return this;
        }
        public Grid Name(string name)
        {
            this._name = name;
            return this;
        }
        public Grid ID(string id)
        {
            this._id = id;
            return this;
        }
        public override string Render()
        {
            StringBuilder tablebuilder = new StringBuilder();           
            _dicHtmlAttributes.Fill("class",_cssclass);
            if (string.IsNullOrEmpty(this._id))
            {
               this._id = "grid_" + Guid.NewGuid().ToString("D"); //唯一ID的生成               
            }            
            tablebuilder.Append(string.Format("<table {0}{1}>", "id='"+this._id+"' " ,_dicHtmlAttributes.DicToHtmlAttr()));
            foreach (Column col in _columns)
            {
              tablebuilder.Append(string.Format("<th border='0'>{0}</th>",col.ColumnName));
            }
            tablebuilder.Append("</table>");            
            tablebuilder.Append("<script type=\"text/javascript\">jQuery(function(){fan_grid('"+this._id+"','"+this._url+"');});</script>");
            return tablebuilder.ToString();
        }
    }
}
