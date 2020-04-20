using Elsa;
using Elsa.Attributes;
using Elsa.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elsa_Workflow.Activities
{
    [ActivityDefinition(Category = "Users", Description = "Activate a User", Icon = "fas fa-user-check", Outcomes = new[] { OutcomeNames.Done, "Not Found" })]
    public class ActivateUser : Activity
    {
        // TODO
    }
}
