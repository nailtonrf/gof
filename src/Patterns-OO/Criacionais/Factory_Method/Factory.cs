namespace Patterns_OO.Criacionais.Factory_Method
{
    /* Define uma interface para criação de um objeto, mas permite que as subclasses decidam qual classe será instanciada.
     * Permite que uma classe delegue a instanciação para subclasses.
     * Definindo um construtor virtual.
     * CUIDADO COM O NEW!!!! New promove um alto acoplamento em objetos que se interagem. Utilize Inversão de Controle!!!!
     * 
     * Um frmaework precisa padronizar o modelo arquitetural para uma gama de aplicações, mas permite que, individualmente, cada aplicação possa prover seu próprio domínio.*/

    #region Implementação semelhante ao AbractFactory
    public abstract class Factory
    {
        public abstract ITradutor CriarTradutor(string frase);
    }

    public sealed class FactoryIngles : Factory
    {
        public override ITradutor CriarTradutor(string frase)
        {
            return new TradutorIngles();
        }
    }

    public sealed class FactoryAlemao : Factory
    {
        public override ITradutor CriarTradutor(string frase)
        {
            return new TradutorAlemao();
        }
    }
    #endregion

    #region Implementação Popular com um método estático que retorna um objeto de determinado tipo
    public sealed class FactoryMethod
    {
        public enum Idioma { Ingles, Alemao };

        public static ITradutor CriarTradutor(Idioma idioma)
        {
            if (idioma == Idioma.Ingles)
            {
                return new TradutorIngles();
            }
            return new TradutorAlemao();
        }
    }
    #endregion

    public interface ITradutor
    {
        string Traduzir(string frase);
    }

    public class TradutorIngles : ITradutor
    {
        public string Traduzir(string frase)
        {
            return $"{frase} em Ingles";
        }
    }

    public class TradutorAlemao : ITradutor
    {
        public string Traduzir(string frase)
        {
            return $"{frase} em Alemao";
        }
    }
}