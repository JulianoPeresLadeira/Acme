using Acme.Domain.DTOs;

namespace Acme.Sample.Objects
{
    public static class Products
    {
        public static IEnumerable<Product> GetElements()
        {
            return new List<Product>
            {
                new Product
                {
                    ID = 1,
                    Name = "Super Outfit",
                    Description = "Doesn't give one the ability to fly",
                    SKU = "LT0001"
                },
                new Product
                {
                    ID = 2,
                    Name = "Matches",
                    Description = "Regular, everyday matches, good for igniting things",
                    SKU = "MM0001"
                },
                new Product
                {
                    ID = 3,
                    Name = "Rocket-Powered Roller Skates",
                    Description = "Let you skate at unlimited speed",
                    SKU = "MM0002"
                },
                new Product
                {
                    ID = 4,
                    Name = "Street Cleaners Wagon",
                    Description = "Can be used for trash can or as a customizeable balloon basket",
                    SKU = "MM0003"
                },
                new Product
                {
                    ID = 5,
                    Name = "Giant Kite Kit",
                    Description = "Can used as a regular kite, or can be used to fly and drop weapons",
                    SKU = "MM0004"
                },
                new Product
                {
                    ID = 6,
                    Name = "Bird Seed Ver. 1",
                    Description = "Part of a bird's nutritious meal",
                    SKU = "MM0005"
                },
                new Product
                {
                    ID = 7,
                    Name = "Nitroglycerin",
                    Description = "HANDLE WITH EXTREME CARE!",
                    SKU = "MM0006"
                },
                new Product
                {
                    ID = 8,
                    Name = "Detonator",
                    Description = "Can be used as an activation to be attached to explosives",
                    SKU = "MM0007"
                },
                new Product
                {
                    ID = 9,
                    Name = "Glue V1",
                    Description = "A real sticky adhesive",
                    SKU = "LT0002"
                },
                new Product
                {
                    ID = 10,
                    Name = "Smoke Screen Bomb",
                    Description = "Creates a cloud of smoke, like fog, for camouflage",
                    SKU = "MM0008"
                }
            };
        }
    }
}
