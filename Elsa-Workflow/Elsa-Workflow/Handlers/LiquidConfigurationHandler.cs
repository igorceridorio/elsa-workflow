﻿using Elsa.Scripting.Liquid.Messages;
using Elsa_Workflow.Models;
using Fluid;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Elsa_Workflow.Handlers
{
    /// <summary>
    /// Configure the Liquid template context to allow access to certain models. 
    /// </summary>
    public class LiquidConfigurationHandler : INotificationHandler<EvaluatingLiquidExpression>
    {
        public Task Handle(EvaluatingLiquidExpression notification, CancellationToken cancellationToken)
        {
            var context = notification.TemplateContext;
            
            // Register here the custom created models
            context.MemberAccessStrategy.Register<User>();
            context.MemberAccessStrategy.Register<RegistrationModel>();

            return Task.CompletedTask;
        }
    }
}
