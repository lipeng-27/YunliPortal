using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace YunliPortal.Pages
{
    public class Topic1Model : PageModel
    {
        private readonly ILogger<Topic1Model> _logger;

        public Topic1Model(ILogger<Topic1Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}