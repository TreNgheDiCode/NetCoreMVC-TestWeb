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

                if (!context.Books.Any()) {
                    context.Books.AddRange(new Book()
                    {
                        name = "Lập trình web cơ bản",
                        image= "https://images.unsplash.com/photo-1544947950-fa07a98d237f?w=1000&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8M3x8Ym9vayUyMGNvdmVyfGVufDB8fDB8fHww",
                        description= "Sách dành cho ai học web",
                        price= 399.000,
                        quantity = 1
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
