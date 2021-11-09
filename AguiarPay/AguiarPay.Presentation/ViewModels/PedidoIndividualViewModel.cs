using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AguiarPay.Presentation.ViewModels
{
    public class PedidoIndividualViewModel
    {
        public Guid Id { get; set; }
        public Guid ComandaIndividualId { get; set; }
        public ComandaIndividualViewModel ComandaIndividual { get; set; }
        public Guid ProdutoId { get; set; }
        public ProdutoViewModel Produto { get; set; }
    }
}
