using MVC_VET.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_VET.Web.Data.Repositories
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }

        //método que vais buscar os animais todos e ordena por nome
        public IEnumerable<Animal> GetAnimals()
        {
            return _context.Animals.OrderBy(a => a.Nome);
        }


        // método que vai buscar um animal pelo id
        public Animal GetAnimal(int id)
        {
            return _context.Animals.Find(id);
        }

        //método que vai adicionar um produto a tabela
        public void AddAnimal(Animal animal)
        {
            _context.Animals.Add(animal);
        }

        //metodo que atualiza (update) um produto
        public void UpdateAnimal(Animal animal)
        {
            _context.Update(animal);
        }

        //metodo que remove um produto
        public void RemoveAnimal(Animal animal)
        {
            _context.Animals.Remove(animal);
        }

        //Metodo que atualiza a BD
        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        //Verifica se o produto existe
        public bool AnimalExists(int Id)
        {
            return _context.Animals.Any(p => p.Id == Id);
        }




    }
}
