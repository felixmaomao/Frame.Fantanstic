using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame.Fantastic
{
    public class PassWord:FantasticHelperBase
    {
        //data
        private string _cssclass;
        private IDictionary<string, string> _dicHtmlAttributes = new Dictionary<string, string>();        
        private string _value;

        public PassWord CssClass(string cssclass)
        {
            this._cssclass = cssclass;
            return this;
        }
     

        public override string Render()
        {
            this._dicHtmlAttributes.Add("id", "pass_"+Guid.NewGuid().ToString("D"));//todo
            this._dicHtmlAttributes.Add("type", "password");         
            return string.Format("<input {0} />",  _dicHtmlAttributes.DicToHtmlAttr());
        }

        public override string ToString()
        {
            return Render();
        }
    }
}
