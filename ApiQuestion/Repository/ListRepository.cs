using ApiQuestion.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiQuestion.Repository
{

    public class ListRepository : IListRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ListRepository(ApplicationDbContext _applicationDbContext)
        {
            this.applicationDbContext = _applicationDbContext;
        }

        public async Task<IEnumerable<ListaModel>> GetListElements()
        {
            var listElements = await applicationDbContext.ListaCTX
                                      .ToListAsync();

            return listElements;
        }
    }
}
