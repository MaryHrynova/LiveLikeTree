using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveLikeTree.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public ApplicationUser User { get; set; }
        
        public ICollection<Tree> Trees { get; set; }
    }
}