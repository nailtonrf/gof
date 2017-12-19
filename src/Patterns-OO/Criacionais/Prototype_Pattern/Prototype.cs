namespace Patterns_OO.Criacionais.Prototype_Pattern
{
    /* Especifique os tipos de objetos a serem criados usando uma instância prototípica e crie novos objetos copiando esse protótipo.*/
    public abstract class RegrasArmazenagemPrototype<T> where T : class
    {
        public string Descricao { get; protected set; }
        public decimal ValorFranquia { get; protected set; }
        public decimal DescontoMaximoPermitido { get; protected set; }

        public T Clonar()
        {
            return MemberwiseClone() as T;
        }

        public override string ToString()
        {
            return Descricao;
        }
    }

    public class RegrasArmazenagemProdutosInflamaveis : RegrasArmazenagemPrototype<RegrasArmazenagemProdutosInflamaveis>
    {
        public RegrasArmazenagemProdutosInflamaveis()
        {
            Descricao = "Inflamaveis";
            ValorFranquia = 100;
            DescontoMaximoPermitido = 10;
        }
    }

    public class RegrasArmazenagemAlimentos : RegrasArmazenagemPrototype<RegrasArmazenagemAlimentos>
    {
        public RegrasArmazenagemAlimentos()
        {
            Descricao = "Alimentos";
            ValorFranquia = 100;
            DescontoMaximoPermitido = 10;
        }
    }
}