using System;
using System.Collections.Generic;
using System.Text;

namespace AguiarPay.Business.Models
{
    public class PedidoColetivo : Entity
    {       
        public Guid ComandaColetivaId { get; set; }
        public ComandaColetiva ComandaColetiva { get; set; }
        public Guid ProdutoId { get; set; }
        public Produto Produto { get; set; }
        
    }
}
