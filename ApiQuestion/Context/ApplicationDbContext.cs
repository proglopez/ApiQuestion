using ApiQuestion.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ApiQuestion.Repository
{
    [ExcludeFromCodeCoverage]
    public class ApplicationDbContext : DbContext
    {
                                                                                                                            #pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
                                                                                                                            #pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        {
        }
            public virtual DbSet<ListaModel> ListaCTX { get; set; }
    }
}
