using Microsoft.EntityFrameworkCore;

namespace Adatbázis_kapcs.Models
{
    public class AdatbázisKapcsolat:DbContext
    {
        public AdatbázisKapcsolat(DbContextOptions<AdatbázisKapcsolat>options):base(options)
        {

        }
        //táblák
        public DbSet<Felhasznalok> Felhasznaloks { get; set; }
    }
}
