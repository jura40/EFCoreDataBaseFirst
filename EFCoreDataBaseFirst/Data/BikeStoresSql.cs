using EFCoreDataBaseFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDataBaseFirst.Data
{
    public class BikeStoresSql : IBikeStores
    {
        private BikeStoresSql(BikeStoresContext bikeStoresContext)
        {
            BikeStoresContext = bikeStoresContext;
        }

        public BikeStoresContext BikeStoresContext { get; }

        public async Task<IEnumerable<Brand>> GetBrands()
        {
           return await BikeStoresContext.Brands.ToListAsync();
        }
    }
}
