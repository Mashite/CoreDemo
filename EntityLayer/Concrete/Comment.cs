﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentUserName { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDateTime { get; set; }
        public bool CommentStatus { get; set; }
    }
}
