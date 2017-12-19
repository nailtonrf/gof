using Patterns_OO.Criacionais.Abstract_Factory;
using Patterns_OO.Criacionais.Builder;
using Patterns_OO.Criacionais.Factory_Method;
using Patterns_OO.Criacionais.Prototype_Pattern;
using System;

namespace Patterns_OO.Criacionais
{
    public class Padroes_Criacionais
    {
        public static void Apresentar()
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("PADROES CRIACIONAIS");
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("Factory");
            Console.WriteLine(FactoryMethod.CriarTradutor(FactoryMethod.Idioma.Ingles).Traduzir("FactoryMethod"));

            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("AbstractFactory");
            AbstractFactoryRepositorio repositorio = new FactoryRepositorioEmArquivoTexto();
            Console.WriteLine(repositorio.Consulta().ObterNome());
            repositorio = new FactoryRepositorioEmMemoria();
            Console.WriteLine(repositorio.Consulta().ObterNome());
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("Builder");
            var mensagem = new MensageiroPorSMSBuilder()
                .ComDestinatario("4799999999")
                .ComRemetente("4788888888")
                .ComMensagem("Bom dia!")
                .CriarMensagem();
            Console.WriteLine($"Mensagem do Builder - {mensagem}");

            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("Prototype");
            var prototype = new RegrasArmazenagemProdutosInflamaveis();
            var prototypeClone = prototype.Clonar();
            Console.WriteLine(prototypeClone);
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
    }
}
