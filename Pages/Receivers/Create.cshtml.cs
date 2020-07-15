using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web_Messaging_Core_Web_App.BusinessLayer;
using Web_Messaging_Core_Web_App.Models;

namespace Web_Messaging_Core_Web_App.Pages.Receivers
{
    public class CreateModel : PageModel
    {
        private readonly Web_Messaging_Core_Web_App.Models.Web_Messaging_Core_Web_DataContext _context;

        public CreateModel(Web_Messaging_Core_Web_App.Models.Web_Messaging_Core_Web_DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Receiver Receiver { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Receiver.Add(Receiver);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
