using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System.Runtime;
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

namespace SecurityCode
{
    public class GeraCodigoSegurancaActivity : System.Activities.Activity
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

    internal class GeraCodigoSegurancaActivityChild : UiPath.CodedWorkflows.AsyncTaskCodedWorkflowActivity
    {
        public InArgument<string> in_inputHash { get; set; }

        public OutArgument<string> out_strCodigoSha1 { get; set; }

        public OutArgument<int> out_intTamanhoCodigo { get; set; }

        public System.Collections.Generic.IDictionary<string, object> newResult { get; set; }

        public GeraCodigoSegurancaActivityChild()
        {
            DisplayName = "GeraCodigoSeguranca";
        }

        protected override async System.Threading.Tasks.Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, System.Threading.CancellationToken cancellationToken)
        {
            var var_in_inputHash = in_inputHash.Get(context);
            var codedWorkflow = new global::SecurityCode.GeraCodigoSeguranca();
            CodedWorkflowHelper.Initialize(codedWorkflow, new UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatureChecker(new System.Collections.Generic.List<string>()
            {UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatures.AsyncEntrypoints}), context);
            var result = await System.Threading.Tasks.Task.Run(() => CodedWorkflowHelper.RunWithExceptionHandlingAsync(() =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.Before(new BeforeRunContext()
                    {RelativeFilePath = "GeraCodigoSeguranca.cs"});
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }, () =>
            {
                ControlledExecution.Run(() =>
                {
                    {
                        var result = codedWorkflow.Execute(var_in_inputHash);
                        newResult = new System.Collections.Generic.Dictionary<string, object>{{"out_strCodigoSha1", result.out_strCodigoSha1}, {"out_intTamanhoCodigo", result.out_intTamanhoCodigo}, };
                    }
                }, cancellationToken);
                return System.Threading.Tasks.Task.FromResult(newResult);
            }, (exception, outArgs) =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.After(new AfterRunContext()
                    {RelativeFilePath = "GeraCodigoSeguranca.cs", Exception = exception});
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }), cancellationToken);
            return endContext =>
            {
                out_strCodigoSha1.Set(endContext, (string)result["out_strCodigoSha1"]);
                out_intTamanhoCodigo.Set(endContext, (int)result["out_intTamanhoCodigo"]);
            };
        }
    }
}