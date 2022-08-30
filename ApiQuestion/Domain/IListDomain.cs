using ApiQuestion.Entities;

namespace ApiQuestion.Domain.Interfaces
{
    public interface IListDomain
    {
        /// <summary>
        /// Get listado
        /// </summary>
        Task<IEnumerable<ListaModel>> GetListElements();
    }
}
