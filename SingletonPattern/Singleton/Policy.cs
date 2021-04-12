using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    
    public class Policy
    {
        // private static readonly object _lock = new object();

        private static readonly Policy _instance = new Policy();
        public static Policy Instance
        {
            get
            {
                //lock (_lock)
                //{
                //    if (_instance == null) // make sure there is only once instance of Policy
                //    {
                //        return new Policy();
                //    }
                //    else
                //    {
                //        return _instance;
                //    }
                //}

                return _instance;

            }
        }
        public Policy()
        {

        }

        private int Id { get; set; } = 123;
        private string Insured { get; set; } = "John Roy";

        public string GetInsuredName() => Insured;
    }
}
