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
    public class GenerateSha1Activity : Activity
    {
        public GenerateSha1Activity()
        {
            this.Implementation = () =>
            {
                return new GenerateSha1ActivityChild()
                {};
            };
        }
    }

    internal class GenerateSha1ActivityChild : CodeActivity
    {
        public GenerateSha1ActivityChild()
        {
            DisplayName = "GenerateSha1";
        }

        protected override void Execute(CodeActivityContext context)
        {
            var codedWorkflow = new CodigoSeguranca.GenerateSha1();
            CodedWorkflowHelper.Initialize(codedWorkflow, context);
            CodedWorkflowHelper.RunWithExceptionHandling(() =>
            {
                codedWorkflow.Before(new BeforeRunContext()
                {RelativeFilePath = "GenerateSha1.cs"});
            }, () =>
            {
                codedWorkflow.Execute();
                return null;
            }, (exception, outArgs) =>
            {
                codedWorkflow.After(new AfterRunContext()
                {RelativeFilePath = "GenerateSha1.cs", Exception = exception});
            });
        }
    }
}