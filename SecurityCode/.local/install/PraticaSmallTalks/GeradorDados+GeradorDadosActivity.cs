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

namespace SecurityCode.PraticaSmallTalks
{
    public class GeradorDadosActivity : System.Activities.Activity
    {
        public OutArgument<string> out_strTextoSha1 { get; set; }

        public OutArgument<string> out_strNome { get; set; }

        public GeradorDadosActivity()
        {
            this.Implementation = () =>
            {
                return new GeradorDadosActivityChild()
                {out_strTextoSha1 = (this.out_strTextoSha1 == null ? (OutArgument<string>)Argument.CreateReference((Argument)new OutArgument<string>(), "out_strTextoSha1") : (OutArgument<string>)Argument.CreateReference((Argument)this.out_strTextoSha1, "out_strTextoSha1")), out_strNome = (this.out_strNome == null ? (OutArgument<string>)Argument.CreateReference((Argument)new OutArgument<string>(), "out_strNome") : (OutArgument<string>)Argument.CreateReference((Argument)this.out_strNome, "out_strNome")), };
            };
        }
    }

    internal class GeradorDadosActivityChild : UiPath.CodedWorkflows.AsyncTaskCodedWorkflowActivity
    {
        public OutArgument<string> out_strTextoSha1 { get; set; }

        public OutArgument<string> out_strNome { get; set; }

        public System.Collections.Generic.IDictionary<string, object> newResult { get; set; }

        public GeradorDadosActivityChild()
        {
            DisplayName = "GeradorDados";
        }

        protected override async System.Threading.Tasks.Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, System.Threading.CancellationToken cancellationToken)
        {
            var codedWorkflow = new global::SecurityCode.PraticaSmallTalks.GeradorDados();
            CodedWorkflowHelper.Initialize(codedWorkflow, new UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatureChecker(new System.Collections.Generic.List<string>()
            {UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatures.AsyncEntrypoints}), context);
            var result = await System.Threading.Tasks.Task.Run(() => CodedWorkflowHelper.RunWithExceptionHandlingAsync(() =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.Before(new BeforeRunContext()
                    {RelativeFilePath = "PraticaSmallTalks\\GeradorDados.cs"});
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }, () =>
            {
                ControlledExecution.Run(() =>
                {
                    {
                        var result = codedWorkflow.Execute();
                        newResult = new System.Collections.Generic.Dictionary<string, object>{{"out_strTextoSha1", result.out_strTextoSha1}, {"out_strNome", result.out_strNome}, };
                    }
                }, cancellationToken);
                return System.Threading.Tasks.Task.FromResult(newResult);
            }, (exception, outArgs) =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.After(new AfterRunContext()
                    {RelativeFilePath = "PraticaSmallTalks\\GeradorDados.cs", Exception = exception});
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }), cancellationToken);
            return endContext =>
            {
                out_strTextoSha1.Set(endContext, (string)result["out_strTextoSha1"]);
                out_strNome.Set(endContext, (string)result["out_strNome"]);
            };
        }
    }
}