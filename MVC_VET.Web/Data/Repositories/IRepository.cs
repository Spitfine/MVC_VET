using MVC_VET.Web.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVC_VET.Web.Data.Repositories
{
    public interface IRepository
    {
        void AddAnimal(Animal animal);
        bool AnimalExists(int Id);
        Animal GetAnimal(int id);
        IEnumerable<Animal> GetAnimals();
        void RemoveAnimal(Animal animal);
        Task<bool> SaveAllAsync();
        void UpdateAnimal(Animal animal);
    }
}