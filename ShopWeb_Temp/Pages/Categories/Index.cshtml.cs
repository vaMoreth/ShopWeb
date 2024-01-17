using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopWeb_Temp.Data;
using ShopWeb_Temp.Models;

namespace ShopWeb_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public List<Category> CategoryList { get; set; }

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }


        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }
    }
}
