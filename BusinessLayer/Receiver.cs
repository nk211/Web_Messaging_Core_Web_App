using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Messaging_Core_Web_App.BusinessLayer
{
    //The message Receiver details 
    public class Receiver
    {
        public int Id { get; set; }

        //Message receiver name 
        public string ReceiverName { get; set; }

        //Message receiver email
        public string ReceiverEmail { get; set; }

        //Message receiver mobile 
        public string RecieverMobile { get; set; }


    }
}
