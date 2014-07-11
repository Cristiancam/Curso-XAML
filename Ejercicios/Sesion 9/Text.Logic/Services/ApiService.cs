using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text.Logic.Contracts;
using Text.Logic.Models;

namespace Text.Logic.Services
{
    public class ApiService : IApiService
    {
        MobileServiceClient azureService;
        public ApiService()
        {
            azureService = new MobileServiceClient(
                "https://ilimitada.azure-mobile.net/",
                "OgTlbGubnFlbKpwKNzXWjuTRamPjrP89");
        }

        public async Task<IEnumerable<Item>> GetItemsAsync()
        {
            return await azureService.GetTable<Item>().ToListAsync();
        }

        public Task SaveItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
