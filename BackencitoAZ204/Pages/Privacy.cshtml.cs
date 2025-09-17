using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BackencitoAZ204.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        [BindProperty(SupportsGet = true)]
        public bool Throw { get; set; }

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (Throw)
            {
                try
                {
                    throw new ArgumentException("An exception was intentionally thrown from the query string.");
                }
                catch (Exception e)
                {
                    _logger.LogCritical("The application will be shutdown.");
                    throw;
                }
            }
            else
            {
                _logger.LogInformation("Call to route 'Privacy' successfully completed.");
            }
        }
    }

}
