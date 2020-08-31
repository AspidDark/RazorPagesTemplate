using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPages.Pages
{
    // https://www.youtube.com/watch?v=3F9SpUYTB6Y&list=PL6n9fhu94yhX6J31qad0wSO1N_rgGbOPV
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string Message { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Message = $"Hi Tim! {DateTime.Now.ToLongTimeString()}";
        }
    }
}
