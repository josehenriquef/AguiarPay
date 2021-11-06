using System;
using System.Collections.Generic;
using System.Text;

namespace AguiarPay.Business.Models
{
    public class PedidoColetivo : Entity
    {
        public IEnumerable<Produto> Produtos { get; set; }
        public Guid ComandaColetivaId { get; set; }
        public ComandaColetiva ComandaColetiva { get; set; }

    }
}
