using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICardService
    {
        List<Card> Get();

        Card Get(int id);

        bool Add(Card card);

        List<Card> Search(string card);

        bool Delete(int cardId);

        bool Update(Card card);

        void SaveChanges();
    }
}
