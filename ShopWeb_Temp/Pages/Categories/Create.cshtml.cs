using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopWeb_Temp.Data;
using ShopWeb_Temp.Models;

namespace ShopWeb_Temp.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {

        private readonly ApplicationDbContext _db;        
        public Category Category { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        
        public IActionResult OnPost(Category obj)
        {
            _db.Categories.Add(obj);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
