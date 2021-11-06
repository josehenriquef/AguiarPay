using System;
using System.Collections.Generic;
using System.Text;

namespace AguiarPay.Business.Models
{
    public class PedidoIndividual : Entity
    {      
        public Guid ComandaIndividualId { get; set; }
        public ComandaIndividual ComandaIndividual { get; set; }
        public Guid ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
