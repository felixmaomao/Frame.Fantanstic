using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
namespace Frame.Fantastic
{
    public static class FantasticExtensions
    {
        public static FantasticHtmlHelper<T> Fan<T>(this HtmlHelper<T> html)
        {
            return new FantasticHtmlHelper<T>(html);
        }       
    }
}
