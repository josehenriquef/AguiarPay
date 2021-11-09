using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AguiarPay.Presentation.ViewModels
{
    public class ComandaColetivaViewModel
    {
        public Guid Id { get; set; }
        public IEnumerable<PedidoColetivoViewModel> PedidosColetivos { get; set; }
    }
}
