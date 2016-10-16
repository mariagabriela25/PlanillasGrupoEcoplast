using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;
using DataAccess;

namespace BusinessLogic
{
    public class Rest
    {
        public int Code { get; set; }
        public int Minutes { get; set; }

        public void addRest(Rest rest)
        {
            new DAORest().addRest(new TORest
            {
                Code = rest.Code,
                Minutes = rest.Minutes
            });
        }

        public void deleteRest(int code)
        {
            new DAORest().deleteRest(code);
        }

        public List<Rest> getAllRests()
        {
            List<TORest> list = new DAORest().getAllRests();
            List<Rest> rests = new List<Rest>();
            foreach (TORest item in list)
            {
                rests.Add(new Rest {
                    Code = item.Code,
                    Minutes = item.Minutes
                });
            }
            return rests;
        }

        public Rest getRest(int code)
        {
            TORest rest = new DAORest().getRest(code);
            if (rest != null)
            {
                return new Rest
                {
                    Code = rest.Code,
                    Minutes = rest.Minutes
                };
            }
            return null;
        }
    }
}
