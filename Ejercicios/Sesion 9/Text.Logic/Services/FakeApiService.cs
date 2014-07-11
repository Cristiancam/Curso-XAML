using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text.Logic.Contracts;
using Text.Logic.Models;

namespace Text.Logic.Services
{
    public class FakeApiService : IApiService
    {
        public async Task<IEnumerable<Item>> GetItemsAsync()
        {
            List<Item> result = new List<Item>();
            result.Add(new Item() 
            {
                Id = string.Empty,
                Name = "Divorcio",
                Points = 100
            });

            result.Add(new Item()
            {
                Id = string.Empty,
                Name = "Enfermedad",
                Points = 80
            });

            result.Add(new Item()
            {
                Id = string.Empty,
                Name = "Pelea familiar",
                Points = 65
            });

            result.Add(new Item()
            {
                Id = string.Empty,
                Name = "Muerte del padre",
                Points = 95
            });

            return result;
        }

        public async Task SaveItem(Item item)
        {
            return;
        }
    }
}
