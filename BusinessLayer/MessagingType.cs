using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Messaging_Core_Web_App.BusinessLayer
{
    //Message type details
    public class MessagingType
    {
        //Message type internal id 
        public int Id { get; set; }

        //Name of the messaging method (Eg SMS, online etc)
        public string MethodName { get; set; }

    }
}
