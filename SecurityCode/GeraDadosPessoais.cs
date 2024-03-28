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
            var nvPrincipalScreen = uiAutomation.Open("Gerador NV: Tela principal");
            nvPrincipalScreen.Click("GeradorPessoasBtn");
            
            var nvGeradorPessoaScreen = uiAutomation.Attach("Gerador de Pessoa");
            nvGeradorPessoaScreen.SelectItem("EstadoDrop", "RS");
            nvGeradorPessoaScreen.Click("AddPontuacao");
            nvGeradorPessoaScreen.Click("GerarPessoaBtn");
            
            string nome = nvGeradorPessoaScreen.GetText("Nome");
            string dataNascimento = nvGeradorPessoaScreen.GetText("DataNascimento");
            string tituloEleitor = nvGeradorPessoaScreen.GetText("TituloEleitor");
            
            string textoSha1 = MontaTextoSha1(nome, dataNascimento, tituloEleitor);
            
            Log("Retornando input Sha1: "+textoSha1);
            
            return(out_strTextoSha1:textoSha1, out_strNome:nome);
        }
        
        public string MontaTextoSha1(string n, string d, string t){
            return(n+" - "+d+" - "+t);
        }
    }
}