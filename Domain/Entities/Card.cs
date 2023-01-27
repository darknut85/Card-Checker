using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Card : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SetId { get; set; }

        public virtual Set Set { get; set; }

        public int Number { get; set; }

        public bool Owned { get; set; }
    }
}
