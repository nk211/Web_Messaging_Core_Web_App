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
    public class DeleteModel : PageModel
    {
        private readonly Web_Messaging_Core_Web_App.Models.Web_Messaging_Core_Web_DataContext _context;

        public DeleteModel(Web_Messaging_Core_Web_App.Models.Web_Messaging_Core_Web_DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Receiver Receiver { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Receiver = await _context.Receiver.FirstOrDefaultAsync(m => m.Id == id);

            if (Receiver == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Receiver = await _context.Receiver.FindAsync(id);

            if (Receiver != null)
            {
                _context.Receiver.Remove(Receiver);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
