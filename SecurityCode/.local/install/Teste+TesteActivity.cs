using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace CodigoSeguranca
{
    public class testeActivity : Activity
    {
        public testeActivity()
        {
            this.Implementation = () =>
            {
                return new testeActivityChild()
                {};
            };
        }
    }

    internal class testeActivityChild : CodeActivity
    {
        public testeActivityChild()
        {
            DisplayName = "teste";
        }

        protected override void Execute(CodeActivityContext context)
        {
            var codedWorkflow = new CodigoSeguranca.teste();
            CodedWorkflowHelper.Initialize(codedWorkflow, context);
            CodedWorkflowHelper.RunWithExceptionHandling(() =>
            {
                codedWorkflow.Before(new BeforeRunContext()
                {RelativeFilePath = "teste.cs"});
            }, () =>
            {
                codedWorkflow.Execute();
                return null;
            }, (exception, outArgs) =>
            {
                codedWorkflow.After(new AfterRunContext()
                {RelativeFilePath = "teste.cs", Exception = exception});
            });
        }
    }
}