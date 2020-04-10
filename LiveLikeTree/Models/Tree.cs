using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveLikeTree.Models
{
    public class Tree
    {
        public int Id { get; set; }
        public TreeType Type { get; set; }
        public Order Order { get; set; }

    }
}