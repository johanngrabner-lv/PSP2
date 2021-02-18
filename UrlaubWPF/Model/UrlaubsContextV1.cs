using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace UrlaubWPF.Model
{
    class UrlaubsContextV1: DbContext
    {
        public DbSet<Urlaub> Urlaub{ get; set; }

    }
}
