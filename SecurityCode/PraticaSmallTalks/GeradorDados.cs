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

// NOTICE: The Coded Automations feature is available as a preview feature and APIs may be subject to change. 
//         No warranty or technical support is provided for this preview feature.
//         Missing features or encountering bugs? Please click the feedback button in the top-right corner and let us know!
// Please delete these comments after you've read and acknowledged them. For more information, please visit the documentation over at https://docs.uipath.com/studio/lang-en/v2023.10/docs/coded-automations-introduction.
namespace SecurityCode.PraticaSmallTalks
{
    public class GeradorDados : CodedWorkflow
    {
        [Workflow]
        public (string out_strTextoSha1, string out_strNome) Execute()
        {
            var nvPrincipalScreen = uiAutomation.Open("Gerador NV: Tela principal");
            nvPrincipalScreen.Click("GeradorPessoasBtn");
            
            var nvGeradorPessoasScreen = uiAutomation.Attach("Gerador de Pessoa");
            nvGeradorPessoasScreen.SelectItem("EstadoDrop","RS");
            
            nvGeradorPessoasScreen.Click("AddPontuacao");
            nvGeradorPessoasScreen.Click("GerarPessoaBtn");
            
            string nome = nvGeradorPessoasScreen.GetText("Nome");
            string dataNascimento = nvGeradorPessoasScreen.GetText("DataNascimento");
            string tituloEleitor = nvGeradorPessoasScreen.GetText("TituloEleitor");
            
            string textoSha1 = MontaTextoSha1(nome, dataNascimento, tituloEleitor);
            Log(textoSha1);
            return(out_strTextoSha1:textoSha1, out_strNome:nome);
        }
        
        public string MontaTextoSha1(string n, string d, string t)
        {
            return(n+" - "+d+" - "+t);
        }
    }
}