using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web_Messaging_Core_Web_App.BusinessLayer;
using Web_Messaging_Core_Web_App.Models;

namespace Web_Messaging_Core_Web_App.Pages.Receivers
{
    public class IndexModel : PageModel
    {
        private readonly Web_Messaging_Core_Web_App.Models.Web_Messaging_Core_Web_DataContext _context;

        public IndexModel(Web_Messaging_Core_Web_App.Models.Web_Messaging_Core_Web_DataContext context)
        {
            _context = context;
        }

        public IList<Receiver> Receiver { get;set; }

        public async Task OnGetAsync()
        {
            Receiver = await _context.Receiver.ToListAsync();
        }
    }
}
