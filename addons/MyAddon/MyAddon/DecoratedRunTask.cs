using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tricentis.TCAddOns;
using Tricentis.TCAPIObjects.Objects;

namespace MyAddon
{
    internal class DecoratedRunTask : TCAddOnTask
    {
        public override string Name => "RunMe";

        public override Type ApplicableType => typeof(ExecutionEntry);

        public override TCObject Execute(TCObject objectToExecuteOn, TCAddOnTaskContext taskContext)
        {
            taskContext.ShowMessageBox("Attention", String.Format("This entyr will be run via an AddOnTask: CWD: {0}", Environment.CurrentDirectory));
            (objectToExecuteOn as ExecutionEntry).Run();
            return null;
        }
    }
}
