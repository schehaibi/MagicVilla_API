using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }
        public DbSet<Usermod> Usermod { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg",
                    ImageUrl = "",
                    Occupancy = 4,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                },
                  new Villa
                  {
                      Id = 2,
                      Name = "Royal Villa2",
                      Details = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg",
                      ImageUrl = "",
                      Occupancy = 4,
                      Rate = 200,
                      Sqft = 550,
                      Amenity = "",
                      CreatedDate = DateTime.Now,
                      UpdateDate = DateTime.Now,
                  },
                    new Villa
                    {
                        Id = 3,
                        Name = "Royal Villa3",
                        Details = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg",
                        ImageUrl = "",
                        Occupancy = 4,
                        Rate = 200,
                        Sqft = 550,
                        Amenity = "",
                        CreatedDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                    },
                      new Villa
                      {
                          Id = 4,
                          Name = "Royal Villa4",
                          Details = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg",
                          ImageUrl = "",
                          Occupancy = 4,
                          Rate = 200,
                          Sqft = 550,
                          Amenity = "",
                          CreatedDate = DateTime.Now,
                          UpdateDate = DateTime.Now,
                      },
                        new Villa
                        {
                            Id = 5,
                            Name = "Royal Villa5",
                            Details = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg",
                            ImageUrl = "",
                            Occupancy = 4,
                            Rate = 200,
                            Sqft = 550,
                            Amenity = "",
                            CreatedDate = DateTime.Now,
                            UpdateDate = DateTime.Now,
                            
                        }

                );
        }
    }    
}
