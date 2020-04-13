using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day15.API.Model;

namespace Day15.API.DAL
{
    public class TAPDDAL
    {
        TAPDdataContext TAP = new TAPDdataContext();
        public int Add(TAPDModel m)
        {
            TAP.ts.Add(m);
            return TAP.SaveChanges();
        }
        public List<TAPDModel> Show()
        {
            return TAP.ts.ToList();
        }
        public TAPDModel Find(int id)
        {
            return TAP.ts.Find(id);
        }
        public int Del(string id)
        {
            var fid=TAP.ts.Find(id);
            TAP.ts.Remove(fid);
            return TAP.SaveChanges();
        }

    }
}
