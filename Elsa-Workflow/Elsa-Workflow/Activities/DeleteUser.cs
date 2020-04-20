using Elsa;
using Elsa.Attributes;
using Elsa.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elsa_Workflow.Activities
{
    [ActivityDefinition(Category = "Users", Description = "Delete a User", Icon = "fas fa-user-minus", Outcomes = new[] { OutcomeNames.Done, "Not Found" })]
    public class DeleteUser : Activity
    {
        // TODO
    }
}
