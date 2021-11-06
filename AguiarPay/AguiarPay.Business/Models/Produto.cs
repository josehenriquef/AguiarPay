using System;
using System.Collections.Generic;
using System.Text;

namespace AguiarPay.Business.Models
{
    public class Produto : Entity
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Status { get; set; }
        public PedidoIndividual PedidoIndividual { get; set; }
        public PedidoColetivo PedidoColetivo { get; set; }
        public Guid PedidoIndividualId { get; set; }
        public Guid PedidoColetivoId { get; set; }

    }
}
