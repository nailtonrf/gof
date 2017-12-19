using System;

namespace Patterns_OO.Comportamentais.Visitor_Pattern
{
    public interface IVisitor
    {
        void Visit(Colaborador colaborador);
    }

    public sealed class CalculadorRendaVisitor : IVisitor
    {
        public void Visit(Colaborador colaborador)
        {
            colaborador.AtualizarRenda(colaborador.Renda * 1.10);
            Console.WriteLine($"Colaborador {colaborador.Nome} - Renda {colaborador.Renda}.");
        }
    }

    public sealed class CalculadorFeriasVisitor : IVisitor
    {
        public void Visit(Colaborador colaborador)
        {
            colaborador.AtualizarDiasFerias(colaborador.DiasFerias + 3);
            Console.WriteLine($"Colaborador {colaborador.Nome} - Dias de Ferias {colaborador.DiasFerias}.");
        }
    }


    public interface IElement
    {
        void Accept(IVisitor visitor);
    }

    public sealed class Colaborador : IElement
    {
        public string Nome { get; private set; }
        public double Renda { get; private set; }
        public int DiasFerias { get; set; }

        public Colaborador(string nome, double renda, int diasFerias)
        {
            Nome = nome;
            Renda = renda;
            DiasFerias = diasFerias;
        }
        
        public void AtualizarRenda(double renda)
        {
            Renda = renda;
        }

        public void AtualizarDiasFerias(int diasFerias)
        {
            DiasFerias = diasFerias;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}