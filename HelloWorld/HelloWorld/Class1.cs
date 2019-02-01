using Tricentis.Automation.AutomationInstructions.TestActions;
using Tricentis.Automation.Creation;
using Tricentis.Automation.Engines;
using Tricentis.Automation.Engines.SpecialExecutionTasks;
using Tricentis.Automation.Engines.SpecialExecutionTasks.Attributes;

namespace Tutorial
{
    [SpecialExecutionTaskName("HelloWorld")]
    public class HelloWorld : SpecialExecutionTask
    {
        public HelloWorld(Validator validator) : base(validator)
        {
        }

        public override ActionResult Execute(ISpecialExecutionTaskTestAction testAction)
        {
            return new PassedActionResult("Hello World!");
        }
    }
}
