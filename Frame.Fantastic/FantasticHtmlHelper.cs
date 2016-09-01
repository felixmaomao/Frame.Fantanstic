using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
namespace Frame.Fantastic
{
    public class FantasticHtmlHelper<T>
    {
        public FantasticHtmlHelper(HtmlHelper<T> html)
        {
            this.Html = html;
        }
        public HtmlHelper<T> Html { get; set; }
    
    }
}
