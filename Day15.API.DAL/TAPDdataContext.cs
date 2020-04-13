using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day15.API.Model;
namespace Day15.API.DAL
{
    public class TAPDdataContext:DbContext
    {
        public TAPDdataContext() : base("conn") { }
        public DbSet<TAPDModel> ts { get; set; }
    }
}
