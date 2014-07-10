using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text.Logic.Models;

namespace Text.Logic.Contracts
{
    public interface IApiService
    {
        Task<IEnumerable<Item>> GetItemsAsync();
    }
}
