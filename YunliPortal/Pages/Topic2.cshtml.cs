using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace YunliPortal.Pages
{
    public class Topic2Model : PageModel
    {
        private readonly ILogger<Topic2Model> _logger;

        public Topic2Model(ILogger<Topic2Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}