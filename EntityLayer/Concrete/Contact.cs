using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string ContactUserName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactSubject { get; set; }
        public string ContactMessage { get; set; }
        public DateTime ContactDateTime { get; set; }
        public bool ContactStatus { get; set; }
    }
}
