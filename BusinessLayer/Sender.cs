using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Messaging_Core_Web_App.BusinessLayer
{
    //Message sender details
    public class Sender
    {
        //Message sender internal id
        public int Id { get; set; }

        //Sender name
        public string SenderName { get; set; }

        //Sender email
        public string SenderEmail { get; set; }
    }
}
