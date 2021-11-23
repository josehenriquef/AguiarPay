using System;
using System.Collections.Generic;
using System.Text;

namespace AguiarPay.Business.Models
{
    public class Produto : Entity
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public bool Status { get; set; }
        public IEnumerable<PedidoIndividual> PedidosIndividuais { get; set; }
    }
}
