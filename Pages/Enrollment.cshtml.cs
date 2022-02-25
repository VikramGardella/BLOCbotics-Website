using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace blocbotics_website.Pages
{
    public class EnrollmentModel : PageModel
    {

        private readonly ILogger<EnrollmentModel> _logger;

        public EnrollmentModel(ILogger<EnrollmentModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
