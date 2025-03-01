using jobZilaRazor.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace jobZilaRazor.Pages
{
    public class AddblogModel : PageModel
    {
        [BindProperty]
        public string Title { get; set; }

        [BindProperty]
        public string Content { get; set; }

        [BindProperty]
        public string User { get; set; }

        [BindProperty]
        public DateOnly Creationdate { get; set; }

        private ApplicationDBContext _context;
        public AddblogModel(ApplicationDBContext context)
        {

            _context = context;
        }



        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();

            }

            var blog = new Blogs()
            {
                title = Title,
                content = Content,
                user = User,
                creationdate = Creationdate
            };

            _context.blogs.Add(blog);
            _context.SaveChanges();


            return Redirect("Bloglisting");

        }
    }
}
