using jobZilaRazor.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace jobZilaRazor.Pages
{
    public class BloglistingModel : PageModel
    {

		public List<Blogs> Blog { get; set; }

		private ApplicationDBContext _context;
		public BloglistingModel(ApplicationDBContext context)
		{

			_context = context;

		}


		public void OnGet()
		{
			Blog = _context.blogs.ToList();
		}

		
    }
}
