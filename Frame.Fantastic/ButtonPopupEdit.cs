using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame.Fantastic
{
    public class ButtonPopupEdit:ButtonPopup
    {
        public ButtonPopupEdit()
        {
            base.CssClass(ButtonStyle.BtnPrimary);
            base.Text("Edit");
            base.PopupType(Frame.Fantastic.PopupType.PopupEdit);
        }
    }
}
