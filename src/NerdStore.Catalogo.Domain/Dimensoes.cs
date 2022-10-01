using NerdStore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Domain
{
    public class Dimensoes
    {
        public decimal Altura { get; private set; }
        public decimal Largura { get; private set; }
        public decimal Profundidade { get; private set; }

        public Dimensoes(decimal altura, decimal largura, decimal profundidade)
        {
            Altura = altura;
            Largura = largura;
            Profundidade = profundidade;

            Validar();
        }

        public void Validar()
        {
            Validacoes.ValidarSeMenorOuIgual(Altura, 0, "Altura não pode ser menor ou igual a zero");
            Validacoes.ValidarSeMenorOuIgual(Largura, 0, "Largura não pode ser menor ou igual a zero");
            Validacoes.ValidarSeMenorOuIgual(Profundidade, 0, "Profundidade não pode ser menor ou igual a zero");
        }
    }
}
