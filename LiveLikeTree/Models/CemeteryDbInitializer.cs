using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LiveLikeTree.Models
{
    public class CemeteryDbInitializer : DropCreateDatabaseAlways<CemeteryContext>
    {
        protected override void Seed(CemeteryContext db)
        {
                      
            base.Seed(db);
        }
    }
}