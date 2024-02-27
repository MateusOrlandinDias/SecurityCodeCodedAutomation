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

namespace CodigoSeguranca.CodigoSeguranca
{
    public class DadosPessoaisActivity : Activity
    {
        public OutArgument<string> out_strTextoSha1 { get; set; }

        public OutArgument<string> out_strNome { get; set; }

        public DadosPessoaisActivity()
        {
            this.Implementation = () =>
            {
                return new DadosPessoaisActivityChild()
                {out_strTextoSha1 = (this.out_strTextoSha1 == null ? (OutArgument<string>)Argument.CreateReference((Argument)new OutArgument<string>(), "out_strTextoSha1") : (OutArgument<string>)Argument.CreateReference((Argument)this.out_strTextoSha1, "out_strTextoSha1")), out_strNome = (this.out_strNome == null ? (OutArgument<string>)Argument.CreateReference((Argument)new OutArgument<string>(), "out_strNome") : (OutArgument<string>)Argument.CreateReference((Argument)this.out_strNome, "out_strNome")), };
            };
        }
    }

    internal class DadosPessoaisActivityChild : CodeActivity
    {
        public OutArgument<string> out_strTextoSha1 { get; set; }

        public OutArgument<string> out_strNome { get; set; }

        public DadosPessoaisActivityChild()
        {
            DisplayName = "DadosPessoais";
        }

        protected override void Execute(CodeActivityContext context)
        {
            var codedWorkflow = new CodigoSeguranca.DadosPessoais();
            CodedWorkflowHelper.Initialize(codedWorkflow, context);
            var result = CodedWorkflowHelper.RunWithExceptionHandling(() =>
            {
                codedWorkflow.Before(new BeforeRunContext()
                {RelativeFilePath = "CodigoSeguranca\\DadosPessoais.cs"});
            }, () =>
            {
                var result = codedWorkflow.Execute();
                var newResult = new Dictionary<string, object>{{"out_strTextoSha1", result.out_strTextoSha1}, {"out_strNome", result.out_strNome}, };
                return newResult;
            }, (exception, outArgs) =>
            {
                codedWorkflow.After(new AfterRunContext()
                {RelativeFilePath = "CodigoSeguranca\\DadosPessoais.cs", Exception = exception});
            });
            out_strTextoSha1.Set(context, (string)result["out_strTextoSha1"]);
            out_strNome.Set(context, (string)result["out_strNome"]);
        }
    }
}