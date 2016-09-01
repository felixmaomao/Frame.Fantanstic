using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame.Fantastic
{
    public class Page:FantasticHelperBase
    {
        private string _id;
        private int _totalNum;
        private int _perPageNum;
        public Page TotalNum(int num)
        {
            this._totalNum = num;
            return this;
        }
        public Page PerPageNum(int num)
        {
            this._perPageNum = num;
            return this;
        }
        public override string Render()
        {
            int pages = _totalNum / _perPageNum + 1;
            StringBuilder builder = new StringBuilder();
            builder.Append("<ul class=\"pagination\">");
            builder.Append("<li><a href=\"#\">&laquo;</a></li>");
            for (int i=1;i<=pages;i++)
            {
                builder.AppendFormat("<li><a href=\"#\">{0}</a></li>",i);
            }
            builder.Append(" <li><a href=\"#\">&raquo;</a></li>");
            builder.Append("</ul>");
            return builder.ToString();
        }
    }
}
