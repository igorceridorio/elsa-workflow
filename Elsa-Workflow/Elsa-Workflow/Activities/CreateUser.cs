using Elsa;
using Elsa.Attributes;
using Elsa.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elsa_Workflow.Activities
{
    [ActivityDefinition(Category = "Users", Description = "Create a User", Icon = "fas fa-user-plus", Outcomes = new[] { OutcomeNames.Done })]
    public class CreateUser : Activity
    {
        // TODO
    }
}
