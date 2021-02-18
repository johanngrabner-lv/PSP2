using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace UrlaubWPF.Model
{
    class UrlaubsContext: DbContext
    {
        public DbSet<Urlaub> Urlaub{ get; set; }
    }
}
