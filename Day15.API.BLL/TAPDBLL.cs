using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day15.API.Model;
using Day15.API.DAL;

namespace Day15.API.BLL
{
    public class TAPDBLL
    {
        TAPDDAL dal = new TAPDDAL();
        public int Add(TAPDModel m)
        {
            return dal.Add(m);
        }
        public List<TAPDModel> Show()
        {
            return dal.Show();
        }
        public TAPDModel Find(int id)
        {
            return dal.Find(id);
        }
        public int Del(string id)
        {
            return dal.Del(id);
        }
    }
}
