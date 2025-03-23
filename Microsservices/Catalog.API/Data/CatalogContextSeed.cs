using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct) 
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }

        private static IEnumerable<Product> GetMyProducts() 
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "IPhone X",
                    Description = "akdnsaiojdioasjdiojaidojasiodjkiasdjkioasjdioajiodjusaiodjusoiadasdsa",
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "IPhone X",
                    Description = "akdnsaiojdioasjdiojaidojasiodjkiasdjkioasjdioajiodjusaiodjusoiadasdsa",
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "IPhone X",
                    Description = "akdnsaiojdioasjdiojaidojasiodjkiasdjkioasjdioajiodjusaiodjusoiadasdsa",
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "IPhone X",
                    Description = "akdnsaiojdioasjdiojaidojasiodjkiasdjkioasjdioajiodjusaiodjusoiadasdsa",
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "IPhone X",
                    Description = "akdnsaiojdioasjdiojaidojasiodjkiasdjkioasjdioajiodjusaiodjusoiadasdsa",
                }
            };
        }
    }
}
