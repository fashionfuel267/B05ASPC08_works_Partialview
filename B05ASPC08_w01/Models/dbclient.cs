using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace B05ASPC08_w01.Models
{
    public class Dbclient:DbContext
    {
        public DbSet<Client> Clients { get; set; }
    }
}