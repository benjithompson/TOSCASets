using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tricentis.TCAddOns;

namespace MyAddon
{
    public class MyAddon : TCAddOn
    {
        public override string UniqueName => "MyAddon";
        public override string DisplayedName => "My Addon";
    }
}
