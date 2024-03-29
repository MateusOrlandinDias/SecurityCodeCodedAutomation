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
namespace SecurityCode
{
    public class GeraCodigoSeguranca : CodedWorkflow
    {
        [Workflow]
        public (string out_strCodigoSha1, int out_intTamanhoCodigo) Execute(string in_inputHash)
        {
            Console.WriteLine(in_inputHash);
            var sha1Screen = uiAutomation.Open("Sha1 online");
            
            sha1Screen.TypeInto("inputHash", in_inputHash);
            sha1Screen.Click("hashBtn");
            
            string sha1Output = sha1Screen.GetText("codigoSha");
            
            Log("Código SHA1: "+sha1Output);
            
            int tamanhoCodigo = sha1Output.Length;
            
            return(out_strCodigoSha1:sha1Output, out_intTamanhoCodigo:tamanhoCodigo);
        }
    }
}