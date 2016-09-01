using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace Frame.Fantastic
{
    public abstract class FantasticHelperBase : IHtmlString
    {
        public string ToHtmlString()
        {
            return Render();
        }

        //具体的开放出去
        public abstract string Render();

        public override string ToString()
        {
            return Render();
        }
    }
}
