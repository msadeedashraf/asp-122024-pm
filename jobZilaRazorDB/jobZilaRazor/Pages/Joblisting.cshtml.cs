using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using jobZilaRazor.Data;


namespace jobZilaRazor.Pages
{
    public class JoblistingModel : PageModel
    {
        public List<Jobs> Job {  get; set; }

        private ApplicationDBContext _context;
        public JoblistingModel(ApplicationDBContext context)
        {

            _context = context;

        }


        public void OnGet()
        {
            Job = _context.jobs.ToList();
        }
    }
}
