using System;
using System.Collections.Generic;
using System.Text;

namespace AguiarPay.Business.Models
{
    public class PedidoIndividual : Entity
    {
        public IEnumerable<Produto> Produtos { get; set; }
        public Guid ComandaIndividualId { get; set; }
        public ComandaIndividual ComandaIndividual { get; set; }
    }
}
