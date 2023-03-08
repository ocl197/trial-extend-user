using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;
using trial_extend_user.Data;

namespace trial_extend_user.Pages
{
    public class OliverModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        

        public OliverModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            
            

    }
        public ApplicationUser applicationUser { get; set; }

        public string ID{ get; set; }
        public async void OnGet()
        {
            if(User.Identity.IsAuthenticated)
            {
                applicationUser.Id = _userManager.GetUserId(User);
                
            }
            

        }
    }
}
