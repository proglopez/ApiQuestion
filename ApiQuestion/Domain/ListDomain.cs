using ApiQuestion.Domain.Interfaces;
using ApiQuestion.Entities;
using ApiQuestion.Repository;

namespace ApiQuestion.Domain.Classes
{

    public class ListDomain : IListDomain
    {
        private readonly IListRepository listRepository;

        public ListDomain(IListRepository _listRepository)
        {
            this.listRepository = _listRepository;
        }

        public async Task<IEnumerable<ListaModel>> GetListElements()
        {
            return await listRepository.GetListElements();
        }
    }
}
