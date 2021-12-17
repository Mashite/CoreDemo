﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string ContactUserName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactContent { get; set; }
        public string ContactMessage { get; set; }
        public DateTime ContactDateTime { get; set; }
        public bool ContactStatus { get; set; }
    }
}