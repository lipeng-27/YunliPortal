using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace YunliPortal.Pages
{
    public class Topic3Model : PageModel
    {
        private readonly ILogger<Topic3Model> _logger;

        public Topic3Model(ILogger<Topic3Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}