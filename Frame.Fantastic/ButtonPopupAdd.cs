using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame.Fantastic
{
    public class ButtonPopupAdd:ButtonPopup
    {
        public ButtonPopupAdd()
        {
            base.CssClass(ButtonStyle.BtnSuccess);
            base.Text("Add");
            base.PopupType(Frame.Fantastic.PopupType.PopupAdd);
        }
    }
}
