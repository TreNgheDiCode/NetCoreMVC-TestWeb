using TestWeb.Models;

namespace TestWeb.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<DataContext>();

                if (context == null) { return; }

                context.Database.EnsureCreated();

                if (!context.Companies.Any()) {
                    context.Companies.AddRange(new List<Company>()
                    {
                        new Company
                        {
                            CompanyName = "Apple",
                            Address = "123 Street",
                            Mobiles = new List<Mobile>()
                            {
                                new Mobile
                                {
                                    MobileName = "Iphone15",
                                    MobileImage = "iphone15.jpg",
                                    Price = 22000000,
                                    Description = "Iphone15",
                                }
                            }
                        },
                        new Company
                        {
                            CompanyName = "Samsung",
                            Address = "456 Street",
                             Mobiles = new List<Mobile>()
                            {
                                new Mobile
                                {
                                    MobileName = "Galaxy Flip 5",
                                    MobileImage = "flip5.jpg",
                                    Price = 20000000,
                                    Description = "Samsung Galaxy Flip",
                                }
                            }
                        }
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
