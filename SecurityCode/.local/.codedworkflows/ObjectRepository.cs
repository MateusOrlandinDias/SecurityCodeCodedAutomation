using UiPath.CodedWorkflows.DescriptorIntegration;

namespace SecurityCode.ObjectRepository
{
    public static class Descriptors
    {
        public static class CodigoSeg
        {
            static string _reference = "FVRF9SbugkqXU0ZQWrUWQQ/XBbyV5Su60elailAzV82Bg";
            public static _Implementation._CodigoSeg.__Gerador_de_Pessoa Gerador_de_Pessoa { get; private set; } = new _Implementation._CodigoSeg.__Gerador_de_Pessoa();
            public static _Implementation._CodigoSeg.__Gerador_NV__Tela_principal Gerador_NV__Tela_principal { get; private set; } = new _Implementation._CodigoSeg.__Gerador_NV__Tela_principal();
            public static _Implementation._CodigoSeg.__Sha1_online Sha1_online { get; private set; } = new _Implementation._CodigoSeg.__Sha1_online();
        }
    }
}

namespace SecurityCode._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }

    namespace _CodigoSeg._Gerador_de_Pessoa
    {
        public class __AddPontuacao : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __AddPontuacao(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "FVRF9SbugkqXU0ZQWrUWQQ/gn7H6D67_Ui0D3NMBUVObQ", DisplayName = "AddPontuacao", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CodigoSeg._Gerador_de_Pessoa
    {
        public class __DataNascimento : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __DataNascimento(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "FVRF9SbugkqXU0ZQWrUWQQ/lGBZSFJESUy0vuquY7kOSA", DisplayName = "DataNascimento", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CodigoSeg._Gerador_de_Pessoa
    {
        public class __EstadoDrop : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __EstadoDrop(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "FVRF9SbugkqXU0ZQWrUWQQ/23MFBu2f8EuTCXLZbjDpsw", DisplayName = "EstadoDrop", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CodigoSeg._Gerador_de_Pessoa
    {
        public class __GerarPessoaBtn : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __GerarPessoaBtn(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "FVRF9SbugkqXU0ZQWrUWQQ/Dn9157jjZ0ygvo3GbNRt_g", DisplayName = "GerarPessoaBtn", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CodigoSeg._Gerador_de_Pessoa
    {
        public class __Nome : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Nome(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "FVRF9SbugkqXU0ZQWrUWQQ/ikSPFhQ-2ke1lLRNxweeSg", DisplayName = "Nome", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CodigoSeg._Gerador_de_Pessoa
    {
        public class __TituloEleitor : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __TituloEleitor(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "FVRF9SbugkqXU0ZQWrUWQQ/fwiXA79y90uSICtkgdMyxQ", DisplayName = "TituloEleitor", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CodigoSeg
    {
        public class __Gerador_de_Pessoa : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Gerador_de_Pessoa()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "FVRF9SbugkqXU0ZQWrUWQQ/1Dhz0v0CX068xyxxQv436g", DisplayName = "Gerador de Pessoa", Screen = this};
                AddPontuacao = new _Implementation._CodigoSeg._Gerador_de_Pessoa.__AddPontuacao(this, null);
                DataNascimento = new _Implementation._CodigoSeg._Gerador_de_Pessoa.__DataNascimento(this, null);
                EstadoDrop = new _Implementation._CodigoSeg._Gerador_de_Pessoa.__EstadoDrop(this, null);
                GerarPessoaBtn = new _Implementation._CodigoSeg._Gerador_de_Pessoa.__GerarPessoaBtn(this, null);
                Nome = new _Implementation._CodigoSeg._Gerador_de_Pessoa.__Nome(this, null);
                TituloEleitor = new _Implementation._CodigoSeg._Gerador_de_Pessoa.__TituloEleitor(this, null);
            }

            public _Implementation._CodigoSeg._Gerador_de_Pessoa.__AddPontuacao AddPontuacao { get; private set; }

            public _Implementation._CodigoSeg._Gerador_de_Pessoa.__DataNascimento DataNascimento { get; private set; }

            public _Implementation._CodigoSeg._Gerador_de_Pessoa.__EstadoDrop EstadoDrop { get; private set; }

            public _Implementation._CodigoSeg._Gerador_de_Pessoa.__GerarPessoaBtn GerarPessoaBtn { get; private set; }

            public _Implementation._CodigoSeg._Gerador_de_Pessoa.__Nome Nome { get; private set; }

            public _Implementation._CodigoSeg._Gerador_de_Pessoa.__TituloEleitor TituloEleitor { get; private set; }
        }
    }

    namespace _CodigoSeg._Gerador_NV__Tela_principal
    {
        public class __GeradorPessoasBtn : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __GeradorPessoasBtn(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "FVRF9SbugkqXU0ZQWrUWQQ/wNSqW-ipZkys9jxWa_mruA", DisplayName = "GeradorPessoasBtn", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CodigoSeg
    {
        public class __Gerador_NV__Tela_principal : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Gerador_NV__Tela_principal()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "FVRF9SbugkqXU0ZQWrUWQQ/EbbLjvIyJkq327o7pFhEhA", DisplayName = "Gerador NV: Tela principal", Screen = this};
                GeradorPessoasBtn = new _Implementation._CodigoSeg._Gerador_NV__Tela_principal.__GeradorPessoasBtn(this, null);
            }

            public _Implementation._CodigoSeg._Gerador_NV__Tela_principal.__GeradorPessoasBtn GeradorPessoasBtn { get; private set; }
        }
    }

    namespace _CodigoSeg._Sha1_online
    {
        public class __codigoSha : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __codigoSha(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "FVRF9SbugkqXU0ZQWrUWQQ/PfMBxqByuUSUt-1ocrWoJA", DisplayName = "codigoSha", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CodigoSeg._Sha1_online
    {
        public class __hashBtn : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __hashBtn(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "FVRF9SbugkqXU0ZQWrUWQQ/zhbCVJ3fjESc8xItWoCDzw", DisplayName = "hashBtn", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CodigoSeg._Sha1_online
    {
        public class __inputHash : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __inputHash(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "FVRF9SbugkqXU0ZQWrUWQQ/SJaX_5T-x02dx1HhiLSPeg", DisplayName = "inputHash", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _CodigoSeg
    {
        public class __Sha1_online : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Sha1_online()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "FVRF9SbugkqXU0ZQWrUWQQ/6eKylUr_VkqBBtxuPyO_WQ", DisplayName = "Sha1 online", Screen = this};
                codigoSha = new _Implementation._CodigoSeg._Sha1_online.__codigoSha(this, null);
                hashBtn = new _Implementation._CodigoSeg._Sha1_online.__hashBtn(this, null);
                inputHash = new _Implementation._CodigoSeg._Sha1_online.__inputHash(this, null);
            }

            public _Implementation._CodigoSeg._Sha1_online.__codigoSha codigoSha { get; private set; }

            public _Implementation._CodigoSeg._Sha1_online.__hashBtn hashBtn { get; private set; }

            public _Implementation._CodigoSeg._Sha1_online.__inputHash inputHash { get; private set; }
        }
    }
}