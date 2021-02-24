using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_VET.Web.Data;
using MVC_VET.Web.Data.Entities;
using MVC_VET.Web.Data.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_VET.Web.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly IRepository _repository;

        public AnimalsController(IRepository repository)
        {
            
            _repository = repository;
        }

        // GET: Animals
        public IActionResult Index()
        {
            return View( _repository.GetAnimals());
        }

        // GET: Animals/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animal = _repository.GetAnimal(id.Value); 
                
            if (animal == null)
            {
                return NotFound();
            }

            return View(animal);
        }

        // GET: Animals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Animals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,ImageUrl,DataNascimento,Especie,Raca")] Animal animal)
        {
            if (ModelState.IsValid)
            {
                _repository.AddAnimal(animal);
                await _repository.SaveAllAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(animal);
        }

        // GET: Animals/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animal = _repository.GetAnimal(id.Value);
            if (animal == null)
            {
                return NotFound();
            }
            return View(animal);
        }

        // POST: Animals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Edit(int id, [Bind("Id,Nome,ImageUrl,DataNascimento,Especie,Raca")] Animal animal)
        {
            if (id != animal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _repository.UpdateAnimal(animal);
                    await _repository.SaveAllAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_repository.AnimalExists(animal.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(animal);
        }

        // GET: Animals/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animal = _repository.GetAnimal(id.Value);

            if (animal == null)
            {
                return NotFound();
            }

            return View(animal);
        }

        // POST: Animals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var animal = _repository.GetAnimal(id);
            _repository.RemoveAnimal(animal);
            await _repository.SaveAllAsync();
            return RedirectToAction(nameof(Index));
        }
               
    }
}
