namespace Patterns_OO.Criacionais.Abstract_Factory
{
    /* Provê uma interface para criação de famíliar de objetos que se relacionam sem espeficiar suas classes concretas.*/
    public abstract class AbstractFactoryRepositorio
    {
        public abstract IRepositorioConsulta Consulta();
        public abstract IRepositorioEscrita Escrita();
    }


    public sealed class FactoryRepositorioEmMemoria : AbstractFactoryRepositorio
    {
        public override IRepositorioConsulta Consulta()
        {
            return new RepositorioConsultaEmMemoria();
        }

        public override IRepositorioEscrita Escrita()
        {
            return new RepositorioEscritaEmMemoria();
        }
    }

    public sealed class FactoryRepositorioEmArquivoTexto : AbstractFactoryRepositorio
    {
        public override IRepositorioConsulta Consulta()
        {
            return new RepositorioConsultaEmArquivoTexto();
        }

        public override IRepositorioEscrita Escrita()
        {
            return new RepositorioEscritaEmArquivoTexto();
        }
    }


    public interface IRepositorioConsulta
    {
        string ObterNome();
    }

    public interface IRepositorioEscrita
    {
        void CriarNome(string nome);
    }

    public enum TipoRepositorio { Memoria, ArquivoTexto }

    public sealed class RepositorioConsultaEmMemoria : IRepositorioConsulta
    {
        public string ObterNome()
        {
            return "Leitura em memoria";
        }
    }

    public sealed class RepositorioEscritaEmMemoria : IRepositorioEscrita
    {
        public void CriarNome(string nome)
        {
        }
    }

    public sealed class RepositorioConsultaEmArquivoTexto : IRepositorioConsulta
    {
        public string ObterNome()
        {
            return "Leitura em arquivo texto";
        }
    }

    public sealed class RepositorioEscritaEmArquivoTexto : IRepositorioEscrita
    {
        public void CriarNome(string nome)
        {
        }
    }


}