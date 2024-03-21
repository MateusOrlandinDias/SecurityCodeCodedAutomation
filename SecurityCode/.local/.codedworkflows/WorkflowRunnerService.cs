using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
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
using SecurityCode.ObjectRepository;
using System.Threading.Tasks;
using UiPath.Activities.Contracts;

namespace SecurityCode
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the MostrarResultado.xaml
        /// </summary>
        public void MostrarResultado(string in_strCodigoSha1, int in_intTamanhoCodigo)
        {
            var result = _runWorkflowHandler(@"MostrarResultado.xaml", new Dictionary<string, object>{{"in_strCodigoSha1", in_strCodigoSha1}, {"in_intTamanhoCodigo", in_intTamanhoCodigo}}, default, default, default);
        }

        /// <summary>
        /// Invokes the GeraCodigoSeguranca.cs
        /// </summary>
        public (string out_strCodigoSha1, int out_intTamanhoCodigo) GeraCodigoSeguranca(string in_inputHash)
        {
            var result = _runWorkflowHandler(@"GeraCodigoSeguranca.cs", new Dictionary<string, object>{{"in_inputHash", in_inputHash}}, default, default, default);
            return ((string)result["out_strCodigoSha1"], (int)result["out_intTamanhoCodigo"]);
        }

        /// <summary>
        /// Invokes the Base/DadosPessoais.cs
        /// </summary>
        public (string out_strTextoSha1, string out_strNome) DadosPessoais()
        {
            var result = _runWorkflowHandler(@"Base\DadosPessoais.cs", new Dictionary<string, object>{}, default, default, default);
            return ((string)result["out_strTextoSha1"], (string)result["out_strNome"]);
        }

        /// <summary>
        /// Invokes the GeraDadosPessoais.cs
        /// </summary>
        public (string out_strTextoSha1, string out_strNome) GeraDadosPessoais()
        {
            var result = _runWorkflowHandler(@"GeraDadosPessoais.cs", new Dictionary<string, object>{}, default, default, default);
            return ((string)result["out_strTextoSha1"], (string)result["out_strNome"]);
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main()
        {
            var result = _runWorkflowHandler(@"Main.xaml", new Dictionary<string, object>{}, default, default, default);
        }
    }
}