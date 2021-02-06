using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data;
using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.Seeds
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                ApplicationDbContext context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(Categories.Select(c => c.Value));
                }

                //context.Drinks.RemoveRange(context.Drinks);
                if (!context.Foods.Any())
                {
                    var foods = new Food[]
                    {
                         new Food
                         {
                             Name = "Morning Blend",
                             Category = categories["Coffee"],
                             ImageUrl = "https://www.bing.com/images/search?view=detailV2&ccid=5Pgk21p9&id=26B5791DDDF59347242F09E6B5FD294F6C04293A&thid=OIP.5Pgk21p9DfWdirPoJd-NvgHaD8&mediaurl=https%3a%2f%2fpng.pngtree.com%2fthumb_back%2ffw800%2fback_our%2f20190619%2fourmid%2fpngtree-korean-cute-coffee-shop-menu-detail-page-vector-background-material-image_135724.jpg&exph=512&expw=960&q=backgound+coffee+shop+now+images&simid=608049541611851462&ck=6F9D2316B012D5E6B42203BF3CE340CC&selectedIndex=38&FORM=IRPRST",
                             InStock = 20,
                             IsPreferedFood = false,
                             ShortDescription = "Oh, what a beautiful morning. Discover our gentle, refined coffee that combines light, harmonic aromas with an elegant taste.",
                             LongDescription = "Our master blenders have put together an exquisite composition of 100% Arabica beans from the Latin American coffee belt. It’s lightly roasted with delicate hints of chocolate.",
                             Price = 9.99M
                         },
                        new Food
                        {
                            Name = "Colombia Origin",
                            Category = categories["Coffee"],
                            ImageUrl = "https://www.bing.com/images/search?view=detailV2&ccid=5Pgk21p9&id=26B5791DDDF59347242F09E6B5FD294F6C04293A&thid=OIP.5Pgk21p9DfWdirPoJd-NvgHaD8&mediaurl=https%3a%2f%2fpng.pngtree.com%2fthumb_back%2ffw800%2fback_our%2f20190619%2fourmid%2fpngtree-korean-cute-coffee-shop-menu-detail-page-vector-background-material-image_135724.jpg&exph=512&expw=960&q=backgound+coffee+shop+now+images&simid=608049541611851462&ck=6F9D2316B012D5E6B42203BF3CE340CC&selectedIndex=38&FORM=IRPRST",
                            InStock = 20,
                            IsPreferedFood = true,
                            ShortDescription = "a fresh, lively taste with a bounce to it.",
                            LongDescription = "This beloved coffee is single-sourced from high elevations in the Colombian Andes. Colombia Origin is a bright, aromatic coffee with a smooth medium roast. Our hand-harvested 100% Arabica beans give it its rounded texture, vibrant aromas with a subtle fruity flavor.",
                            Price = 9.99M
                        },
                        new Food
                        {
                            Name = "Classic Blend",
                            Category = categories["Coffee"],
                            ImageUrl = "https://www.bing.com/images/search?view=detailV2&ccid=5Pgk21p9&id=26B5791DDDF59347242F09E6B5FD294F6C04293A&thid=OIP.5Pgk21p9DfWdirPoJd-NvgHaD8&mediaurl=https%3a%2f%2fpng.pngtree.com%2fthumb_back%2ffw800%2fback_our%2f20190619%2fourmid%2fpngtree-korean-cute-coffee-shop-menu-detail-page-vector-background-material-image_135724.jpg&exph=512&expw=960&q=backgound+coffee+shop+now+images&simid=608049541611851462&ck=6F9D2316B012D5E6B42203BF3CE340CC&selectedIndex=38&FORM=IRPRST",
                            InStock = 20,
                            IsPreferedFood = true,
                            ShortDescription = "...A sophisticated coffee that could only come from Europe…",
                            LongDescription = "The renowned Tchibo house blend inspired by our European coffee culture. Complex and elegant. Our Röstmeisters single roast these 100% Arabica beans to a bold medium roast with a powerful flavor. It has a satiny finish with rich, lively aromas of red berries and dried fruits.",
                            Price = 9.99M
                        },

                        new Food
                        {
                            Name = "Barley",
                            Category = categories["Grain"],
                            ImageUrl = "https://images.pexels.com/photos/533346/pexels-photo-533346.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=450&w=450",
                            InStock = 20,
                            IsPreferedFood = false,
                            ShortDescription = "Barley, a member of the grass family, is a major cereal grain grown in temperate climates globally.",
                            LongDescription = "It was one of the first cultivated grains, particularly in Eurasia as early as 10,000 years ago. Barley has been used as animal fodder, as a source of fermentable material for beer and certain distilled beverages, and as a component of various health foods. It is used in soups and stews, and in barley bread of various cultures. Barley grains are commonly made into malt in a traditional and ancient method of preparation.",
                            Price = 1.6M
                        },
                        new Food
                        {
                            Name = "Butter",
                            Category = categories["Milk"],
                            ImageUrl = "https://images.pexels.com/photos/531334/pexels-photo-531334.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=450",
                            InStock = 20,
                            IsPreferedFood = false,
                            ShortDescription = "Butter is a dairy product with high butterfat content which is solid when chilled and at room temperature in some regions, and liquid when warmed.",
                            LongDescription = "It is made by churning fresh or fermented cream or milk to separate the butterfat from the buttermilk. It is generally used as a spread on plain or toasted bread products and a condiment on cooked vegetables, as well as in cooking, such as baking, sauce making, and pan frying. Butter consists of butterfat, milk proteins and water, and often added salt.",
                            Price = 5.0M
                        },
                        new Food
                        {
                            Name = "Cheese",
                            Category = categories["Milk"],
                            ImageUrl = "https://images.pexels.com/photos/821365/pexels-photo-821365.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=450&w=450",
                            InStock = 20,
                            IsPreferedFood = true,
                            ShortDescription = "Cheese is a dairy product derived from milk that is produced in a wide range of flavors, textures, and forms by coagulation of the milk protein casein.",
                            LongDescription = "It comprises proteins and fat from milk, usually the milk of cows, buffalo, goats, or sheep. During production, the milk is usually acidified, and adding the enzyme rennet causes coagulation. The solids are separated and pressed into final form.",
                            Price = 4.4M
                        }
                    };


                    //foreach (var food in foods)
                    //{
                    //    food.ImageUrl = $"/images/Foods/{food.Name}.png";
                    //}

                    context.AddRange(foods);
                }

                context.SaveChanges();
            }
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category
                        {
                            Name = "Coffee",
                            Description = "All Coffee and legumes/beans ",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0409/4666/3577/products/product-classic-12_480x480.png?v=1600269098",
                        },
                    new Category
                    {
                        Name = "Fruit",
                        Description = "All fruits",
                        ImageUrl = "https://images.pexels.com/photos/8066/fruits-market-colors.jpg?auto=compress&cs=tinysrgb&dpr=1&w=450"
                    },
                    new Category
                    {
                        Name = "Grain",
                        Description = "Grain (cereal) foods, mostly wholegrain and/or high cereal fibre varieties",
                        ImageUrl = "https://images.pexels.com/photos/1537169/pexels-photo-1537169.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=450&w=450"
                    },
                 
                    new Category
                    {
                        Name = "Milk",
                        Description = "Milk, yoghurt cheese and/or alternatives, mostly reduced fat",
                        ImageUrl = "https://images.pexels.com/photos/416656/pexels-photo-416656.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=450&w=450"
                    }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        //genre.ImageUrl = $"/images/Categories/{genre.Name}.png";
                        categories.Add(genre.Name, genre);
                    }
                }

                return categories;
            }
        }
    }
}