using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemsAlgorithms;

namespace DataStructures.Tests
{
    
    [TestClass]
    public class GenericTests
    {
        [TestMethod]
        public void StorePhoneNumbersEffeciently()
        {

            var phoneNumbers = Utilities.RandomPhoneNumberGenerator(1000);

            GenericProblems problemsSolver = new GenericProblems();
            problemsSolver.StorePhoneNumbersEffiecently(phoneNumbers);

            foreach (var phoneNumber in phoneNumbers)
            {
                Console.WriteLine("{0:###-###-####}", phoneNumber);
            }
        }
    }
}
