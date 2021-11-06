using System;
using System.Collections.Generic;
using System.Text;

namespace AguiarPay.Business.Models
{
    public class Entity
    {
        public Guid Id { get; set; }

        public Entity()
        {
            Id = new Guid();
        }
    }
}
