using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    // Abstract Factory
    /*
     * Start off by creating an abstract class.
     * 
     * Operations:
     * Create Savings Account
     * Create Loan Account
     */
    public abstract class ICreditUnionFactory
    {
        public abstract ISavingsAccount CreateSavingsAccount();
        public abstract ILoanAccount CreateLoanAccount();
    }

    /*
    * Next, create an abstraction for the products, 
    * ILoanAccount and ISavingsAccount will be implemented
    */

    // Abstract Product A
    public interface ILoanAccount { }

    // Abstract Product B
    public interface ISavingsAccount { }
}
