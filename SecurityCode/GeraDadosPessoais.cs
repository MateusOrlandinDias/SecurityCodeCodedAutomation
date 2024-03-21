using SecurityCode.ObjectRepository;
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

namespace SecurityCode
{
    public class GeraDadosPessoais : CodedWorkflow
    {
        [Workflow]
        public (string out_strTextoSha1, string out_strNome) Execute()
        {
            //Primeiro Site - Gerador NV
            var nvPrincipalScreen = uiAutomation.Open("Gerador NV: Tela principal");
            nvPrincipalScreen.Click("GeradorPessoasBtn");

            var nvGeradorPessoasScreen = uiAutomation.Attach("Gerador de Pessoa");
            nvGeradorPessoasScreen.SelectItem("EstadoDrop", "RS");
            nvGeradorPessoasScreen.Click("AddPontuacao");
            nvGeradorPessoasScreen.Click("GerarPessoaBtn");
            string nome = nvGeradorPessoasScreen.GetText("Nome");
            string dataNascimento = nvGeradorPessoasScreen.GetText("DataNascimento");
            string tituloEleitor = nvGeradorPessoasScreen.GetText("TituloEleitor");
            
            string textoSha1 = MontaSha1(nome, dataNascimento, tituloEleitor);
            
            Log("Retornando Codigo Sha1: "+textoSha1);
            
            return(out_strTextoSha1:textoSha1, out_strNome:nome);
        }
        
        public string MontaSha1(string n, string d, string t){
            return(n+" - "+d+" - "+t+" - ");
        }
    }
}