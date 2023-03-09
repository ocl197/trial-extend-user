
using trial_extend_user.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using trial_extend_user.Data;

namespace trial_extend_user.Pages


{
	[BindProperties]
	public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;
		private readonly ApplicationDbContext _db;

		public Cow Cow { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext db)
        {
            _logger = logger;
			_db = db;
		}

        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPost()
        {
		
			if (ModelState.IsValid)
			{
				
				
				await _db.Cows.AddAsync(Cow);
				await _db.SaveChangesAsync();

				
				return RedirectToPage("Index");
			}
			return Page();
		}
    }
}