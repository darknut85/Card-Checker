using Domain;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class CardService : ICardService
    {
        private readonly DataContext dataContext;

        public CardService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public bool Add(Card card)
        {
            List<Card> cards = Get();
            bool exists = false;
            foreach (Card item in cards)
            {
                if (item.Name == card.Name)
                {
                    exists = true;
                    break;
                }
            }
            if (!exists)
            {
                dataContext.Set<Card>().Add(card);
                return true;
            }
            return false;
        }

        public bool Delete(int cardId)
        {
            var q = Get(cardId);
            dataContext.Set<Card>().Remove(q);
            return true;
        }

        public List<Card> Get()
        {
            return dataContext.Set<Card>().OrderBy(x => x.Number).ToList();
        }

        public Card Get(int id)
        {
            return dataContext.Set<Card>().FirstOrDefault(x => x.Id == id);
        }

        public List<Card> Search(string card)
        {
            List<Card> c = dataContext.Set<Card>().Where(x => x.Name.Contains(card)).OrderBy(x => x.Number).ToList();
            return c;
        }

        public bool Update(Card card)
        {
            dataContext.Set<Card>().Update(card);
            return true;
        }

        public void SaveChanges()
        {
            dataContext.SaveChanges();
        }
    }
}
