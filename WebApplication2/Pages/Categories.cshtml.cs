using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;

namespace WebApplication2.Pages
{
    public class CategoriesModel : PageModel
    {
        public List<Category> CategoryList { get; set; } = new();

        public void OnGet(int skip = 0, int take = 25)
        {
            for (int i = 0; i <= 100; i++)
            {
                CategoryList.Add(
                    item: new(
                        Id: i,
                        Title: $"Category {i}",
                        Price: i + 10m));
            }
            CategoryList = CategoryList
                .Skip(skip)
                .Take(take)
                .ToList();
        }
    }

    public record Category(int Id, string Title, decimal Price);
}