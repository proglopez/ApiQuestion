using ApiQuestion.Entities;

namespace ApiQuestion.Repository
{
    public interface IListRepository
    {
        /// <summary>
        /// Get listado
        /// </summary>
        Task<IEnumerable<ListaModel>> GetListElements();
    }
}
