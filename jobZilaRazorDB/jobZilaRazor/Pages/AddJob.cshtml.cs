using jobZilaRazor.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace jobZilaRazor.Pages
{
    public class AddJobModel : PageModel
    {

        [BindProperty]
        public string  Title { get; set; }
        
        [BindProperty]
        public string Description { get; set; }
        
        [BindProperty]
        public string Company { get; set; }

        [BindProperty]
        public  string City { get; set; }

        private ApplicationDBContext _context;
        public AddJobModel(ApplicationDBContext context)
        {

            _context = context;
        }



        public void OnGet()
        {
        }

        public IActionResult OnPost() {

            if(!ModelState.IsValid)
            {
                return Page();

            }

            var job = new Jobs()
            {
                title = Title,
                company = Company,
                city = City,
                description = Description
            };

            _context.jobs.Add(job);
            _context.SaveChanges();


            return Redirect("Joblisting");
        
        }
    }
}
