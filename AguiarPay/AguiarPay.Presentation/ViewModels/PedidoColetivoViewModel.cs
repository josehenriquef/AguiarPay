using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AguiarPay.Presentation.ViewModels
{
    public class PedidoColetivoViewModel
    {
        public Guid Id { get; set; }
        public Guid ComandaColetivaId { get; set; }
        public ComandaColetivaViewModel ComandaColetiva { get; set; }
        public Guid ProdutoId { get; set; }
        public ProdutoViewModel Produto { get; set; }
    }
}
