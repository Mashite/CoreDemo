﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public string  WriterImage { get; set; }
        public string WriterEmail { get; set; }
        public string WriterPassword { get; set; }
        public bool WiterStatus { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
