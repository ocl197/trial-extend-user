using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using trial_extend_user.Models;

namespace trial_extend_user.Pages.Cattle
{
    public class IndexModel : PageModel
    {

        public Cow Cow { get; set; }
        public void OnGet()
        {
        }
    }
}
