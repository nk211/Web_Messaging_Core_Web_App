using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web_Messaging_Core_Web_App.BusinessLayer;

namespace Web_Messaging_Core_Web_App.Models
{
    //Used to link the database and the business layer entity classes 
    public class Web_Messaging_Core_Web_DataContext : DbContext
    {
        public Web_Messaging_Core_Web_DataContext (DbContextOptions<Web_Messaging_Core_Web_DataContext> options)
            : base(options)
        {
        }

        public DbSet<Web_Messaging_Core_Web_App.BusinessLayer.Message> Message { get; set; }

        public DbSet<Web_Messaging_Core_Web_App.BusinessLayer.MessagingType> MessagingType { get; set; }

        public DbSet<Web_Messaging_Core_Web_App.BusinessLayer.Receiver> Receiver { get; set; }

        public DbSet<Web_Messaging_Core_Web_App.BusinessLayer.Sender> Sender { get; set; }
    }
}
