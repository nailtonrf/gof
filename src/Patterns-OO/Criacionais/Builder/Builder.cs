namespace Patterns_OO.Criacionais.Builder
{
    /* Separa a construção de um objeto complexo da sua representação para que o mesmo processo de construção possa criar diferentes representações. */
    public enum TipoMensagem { SMS, Email };

    public sealed class Mensagem
    {
        public TipoMensagem Tipo { get; private set; }
        public string Remetente { get; private set; }
        public string Destinatario { get; private set; }
        public string CorpoMensagem { get; private set; }

        public Mensagem(TipoMensagem tipoMensagem, string remetente, string destinatario, string corpoMensagem)
        {
            Tipo = tipoMensagem;
            Remetente = remetente;
            Destinatario = destinatario;
            CorpoMensagem = corpoMensagem;
        }

        public override string ToString()
        {
            return $"Remetente - {Remetente}; Destinatario - {Destinatario}; Menagem - {CorpoMensagem}";
        }
    }

    /* Desta forma cada mensagem pode ter suas próprias validações complexas na especialização do builder abstrato - MensageiroBuilder */
    public abstract class MensageiroBuilderBase
    {
        private TipoMensagem _tipoMensagem;
        private string _remetente;
        private string _destinatario;
        private string _mensagem;

        protected MensageiroBuilderBase ComTipoMensagem(TipoMensagem tipoMensagem)
        {
            _tipoMensagem = tipoMensagem;
            return this;
        }

        public Mensagem CriarMensagem()
        {
            return new Mensagem(_tipoMensagem, _remetente, _destinatario, _mensagem);
        }

        public virtual MensageiroBuilderBase ComDestinatario(string destinatario)
        {
            _destinatario = destinatario;
            return this;
        }
        public virtual MensageiroBuilderBase ComRemetente(string remetente)
        {
            _remetente = remetente;
            return this;
        }

        public virtual MensageiroBuilderBase ComMensagem(string mensagem)
        {
            _mensagem = mensagem;
            return this;
        }
    }

    public sealed class MensageiroPorSMSBuilder : MensageiroBuilderBase
    {
        public MensageiroPorSMSBuilder()
        {
            ComTipoMensagem(TipoMensagem.SMS);
        }
    }

    public sealed class MensageiroPorEmailBuilder : MensageiroBuilderBase
    {
        public MensageiroPorEmailBuilder()
        {
            ComTipoMensagem(TipoMensagem.Email);
        }

        public override MensageiroBuilderBase ComDestinatario(string destinatario)
        {
            //VALIDAÇÃO ESPECIALISTA PARA O EMAIL.                
            return base.ComDestinatario(destinatario);
        }
    }
}