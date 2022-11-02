using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
namespace DalTest
{
    [TestFixture]
    public class Test
    {
        UserOperations op = null;
        public Test()
        {
            op = new UserOperations();
        }
        [TestCase("anand@gmail.com","anand",ExpectedResult =true)]
        [TestCase("varun@gmail.com","anand",ExpectedResult =false)]
        [TestCase("varun@gmail.com","varun",ExpectedResult =true)]
        public bool Validate(string Email, string Password)
        {
            return op.ValidateUser(Email, Password);
        }
    }
}
