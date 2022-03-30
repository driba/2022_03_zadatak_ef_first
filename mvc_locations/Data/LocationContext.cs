using Microsoft.EntityFrameworkCore;
using mvc_locations.Models;

namespace mvc_locations.Data
{
    public class LocationContext : DbContext
    {

        public LocationContext(DbContextOptions<LocationContext> options) : base(options)
        {

        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }

        // Zadatak:
        // kreirati metodu OnModelCreating(ModelBuilder modelBuilder)
        // Napraviti seed podataka za:
        // Minimalno dvije nasumične države s pripadajućim podacima
        // minimalno šest nasumičnih gradova s pripadajućim podacima

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country { 
                    id = 1,
                    country_name = "USA",
                    country_name_eng = "United States",
                    country_code = "1"
                },
                new Country
                {
                    id = 2,
                    country_name = "Hrvatska",
                    country_name_eng = "Croatia",
                    country_code = "385"
                }
            );

            modelBuilder.Entity<City>().HasData(
                new City {
                    id = 1,
                    city_name = "Washington DC",
                    latitude = 38.897957M,
                    longitude = -77.036560M,
                    country_id = 1,                
                },
                new City
                {
                    id = 2,
                    city_name = "New York",
                    latitude = 40.73061M,
                    longitude = -73.740135M,
                    country_id = 1,
                },
                new City
                {
                    id = 3,
                    city_name = "Zagreb",
                    latitude = 45.815399M,
                    longitude = 15.966568M,
                    country_id = 2,
                },
                new City
                {
                    id = 4,
                    city_name = "Rijeka",
                    latitude = 45.328979M,
                    longitude = 14.457664M,
                    country_id = 2,
                },
                new City
                {
                    id = 5,
                    city_name = "Split",
                    country_id = 2,
                    latitude = 43.508133M,
                    longitude = 16.440193M
                },
                new City
                {
                    id = 6,
                    city_name = "Los Angeles",
                    country_id = 1,
                    latitude = 34.052235M,
                    longitude = -118.243683M
                }
            );



        }
    }
}
