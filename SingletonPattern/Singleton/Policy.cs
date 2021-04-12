﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    
    public class Policy
    {
        private static Policy _instance;
        public static Policy Instance
        {
            get
            {
                if(_instance == null) // make sure there is only once instance of Policy
                {
                    return new Policy();
                } else
                {
                    return _instance;
                }
                
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
