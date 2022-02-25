using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace blocbotics_website.Pages
{
    public class CalendarModel : PageModel
    {

        private readonly ILogger<CalendarModel> _logger;

        public CalendarModel(ILogger<CalendarModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
