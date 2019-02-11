using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tricentis.TCAddOns;

namespace MyAddon
{
    class MyRibbonItem : TCAddOnMenuItem
    {
        public override string ID => "RibbonItem1";

        public override string MenuText => "MyAddOnItem";

        public override string MenuItemImageName => "Resources.Icon1.png";

        public override void Execute(TCAddOnTaskContext context)
        {
            context.ShowMessageBox("Ribbon", "You clicked my ribbon item");
        }
    }
}
