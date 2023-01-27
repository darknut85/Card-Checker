using Domain.Interfaces;
using System;

namespace Domain
{
    public class Set : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int TotalCards { get; set; }

        public int OwnedCards { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
