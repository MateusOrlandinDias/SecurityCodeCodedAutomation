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
    public class GeraCodigoSegurancaActivity : Activity
    {
        public InArgument<string> in_inputHash { get; set; }

        public OutArgument<string> out_strCodigoSha1 { get; set; }

        public OutArgument<int> out_intTamanhoCodigo { get; set; }

        public GeraCodigoSegurancaActivity()
        {
            this.Implementation = () =>
            {
                return new GeraCodigoSegurancaActivityChild()
                {in_inputHash = (this.in_inputHash == null ? (InArgument<string>)Argument.CreateReference((Argument)new InArgument<string>(), "in_inputHash") : (InArgument<string>)Argument.CreateReference((Argument)this.in_inputHash, "in_inputHash")), out_strCodigoSha1 = (this.out_strCodigoSha1 == null ? (OutArgument<string>)Argument.CreateReference((Argument)new OutArgument<string>(), "out_strCodigoSha1") : (OutArgument<string>)Argument.CreateReference((Argument)this.out_strCodigoSha1, "out_strCodigoSha1")), out_intTamanhoCodigo = (this.out_intTamanhoCodigo == null ? (OutArgument<int>)Argument.CreateReference((Argument)new OutArgument<int>(), "out_intTamanhoCodigo") : (OutArgument<int>)Argument.CreateReference((Argument)this.out_intTamanhoCodigo, "out_intTamanhoCodigo")), };
            };
        }
    }

    internal class GeraCodigoSegurancaActivityChild : CodeActivity
    {
        public InArgument<string> in_inputHash { get; set; }

        public OutArgument<string> out_strCodigoSha1 { get; set; }

        public OutArgument<int> out_intTamanhoCodigo { get; set; }

        public GeraCodigoSegurancaActivityChild()
        {
            DisplayName = "GeraCodigoSeguranca";
        }

        protected override void Execute(CodeActivityContext context)
        {
            var codedWorkflow = new CodigoSeguranca.GeraCodigoSeguranca();
            CodedWorkflowHelper.Initialize(codedWorkflow, context);
            var result = CodedWorkflowHelper.RunWithExceptionHandling(() =>
            {
                codedWorkflow.Before(new BeforeRunContext()
                {RelativeFilePath = "CodigoSeguranca\\GeraCodigoSeguranca.cs"});
            }, () =>
            {
                var result = codedWorkflow.Execute(in_inputHash.Get(context));
                var newResult = new Dictionary<string, object>{{"out_strCodigoSha1", result.out_strCodigoSha1}, {"out_intTamanhoCodigo", result.out_intTamanhoCodigo}, };
                return newResult;
            }, (exception, outArgs) =>
            {
                codedWorkflow.After(new AfterRunContext()
                {RelativeFilePath = "CodigoSeguranca\\GeraCodigoSeguranca.cs", Exception = exception});
            });
            out_strCodigoSha1.Set(context, (string)result["out_strCodigoSha1"]);
            out_intTamanhoCodigo.Set(context, (int)result["out_intTamanhoCodigo"]);
        }
    }
}