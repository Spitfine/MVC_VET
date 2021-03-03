using MVC_VET.Web.Data.Entities;

namespace MVC_VET.Web.Data.Repositories
{
    public class AnimalRepository : GenericRepository<Animal>, IAnimalRepository
    {
        public AnimalRepository(DataContext context) : base(context)
        {

        }
    }
}
