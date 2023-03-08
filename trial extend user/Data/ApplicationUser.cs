using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using trial_extend_user.Models;

namespace trial_extend_user.Data
{
    public class ApplicationUser : IdentityUser
    {

        //[ForeignKey("Farm")]
        //public int FarmId { get; set; } = 0;
        //public Farm? Farm { get; set; }


    }
}
