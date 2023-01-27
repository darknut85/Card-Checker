using Domain;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class SetService : ISetService
    {
        private readonly DataContext dataContext;

        public SetService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public bool Add(Set set)
        {
            List<Set> sets = Get();
            bool exists = false;
            foreach (Set item in sets)
            {
                if (item.Name == set.Name)
                {
                    exists = true;
                    break;
                }
            }
            if (!exists)
            {
                dataContext.Set<Set>().Add(set);
                return true;
            }
            return false;
        }

        public bool Delete(int setId)
        {
            var q = Get(setId);
            dataContext.Set<Set>().Remove(q);
            return true;
        }

        public List<Set> Get()
        {
            return dataContext.Set<Set>().OrderBy(x => x.ReleaseDate).ToList();
        }

        public Set Get(int id)
        {
            return dataContext.Set<Set>().FirstOrDefault(x => x.Id == id);
        }

        public List<Set> Search(string set)
        {
            return dataContext.Set<Set>().Where(x => x.Name.Contains(set)).OrderBy(x => x.ReleaseDate).ToList();
        }

        public bool Update(Set set)
        {
            dataContext.Set<Set>().Update(set);
            return true;
        }

        public void SaveChanges()
        {
            dataContext.SaveChanges();
        }
    }
}
