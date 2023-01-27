using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ISetService
    {
        List<Set> Get();

        Set Get(int id);

        bool Add(Set set);

        List<Set> Search(string set);

        bool Delete(int setId);

        bool Update(Set set);

        void SaveChanges();
    }
}
