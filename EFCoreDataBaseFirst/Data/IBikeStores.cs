

using EFCoreDataBaseFirst.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFCoreDataBaseFirst.Data
{
    public interface IBikeStores
    {
        Task<IEnumerable<Brand>> GetBrands();
    }
}
