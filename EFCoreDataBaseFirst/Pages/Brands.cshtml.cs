using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreDataBaseFirst.Data;
using EFCoreDataBaseFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreDataBaseFirst.Pages
{
    public class BrandsModel : PageModel
    {
        public List<Brand> Brands;
        private IBikeStores BikeStores { get; }
        public BrandsModel(IBikeStores bikeStores)
        {
            BikeStores = bikeStores;
        }

        

        public async Task<IActionResult> OnGetAsync()
        {
            var brands = await BikeStores.GetBrands();
            Brands = brands.ToList();
            return Page();
        }
    }
}
