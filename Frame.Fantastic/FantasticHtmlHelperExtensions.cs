using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace Frame.Fantastic
{
    public static class FantasticHtmlHelperExtensions
    {
        public static TextBox TextBox<T>(this FantasticHtmlHelper<T> helper)
        {
            return new TextBox();
        }

        public static PassWord PassWord<T>(this FantasticHtmlHelper<T> helper)
        {
            return new PassWord();
        }
        public static Grid Grid<T>(this FantasticHtmlHelper<T> helper)
        {
            return new Grid();
        }
        public static Button Button<T>(this FantasticHtmlHelper<T> helper)
        {
            return new Button();
        }
        public static ButtonPopup ButtonPopup<T>(this FantasticHtmlHelper<T> helper)
        {
            return new ButtonPopup();
        }
        public static ButtonPopupAdd ButtonPopupAdd<T>(this FantasticHtmlHelper<T> helper)
        {
            return new ButtonPopupAdd();
        }
        public static ButtonPopupEdit ButtonPopupEdit<T>(this FantasticHtmlHelper<T> helper)
        {
            return new ButtonPopupEdit();
        }
        public static AjaxList AjaxList<T>(this FantasticHtmlHelper<T> helper)
        {
            return new AjaxList();
        }

        public static AjaxDropDown AjaxDropDown<T>(this FantasticHtmlHelper<T> helper)
        {
            return new AjaxDropDown();
        }

        public static InitPopup InitPopup<T>(this FantasticHtmlHelper<T> helper)
        {
            return new InitPopup();
        }

        public static MessageBox MessageBox<T>(this FantasticHtmlHelper<T> helper)
        {
            return new MessageBox();
        }

        public static SearchBar SearchBar<T>(this FantasticHtmlHelper<T> helper)
        {
            return new SearchBar();
        }

        public static Calendar Calendar<T>(this FantasticHtmlHelper<T> helper)
        {
            return new Calendar();
        }

        public static Page Page<T>(this FantasticHtmlHelper<T> helper)
        {
            return new Page();
        }
    }
}
