using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            //Assert.IsElementPresent(app.ContactHelper.!ContactIsPresent);
            //if (!ContactIsPresent())
            //{
            //manager.ContactHelper.Create();
            //}

            ContactData newData = new ContactData("")
            {
                Firstname = "Ninja",
                Lastname = "Gaiden"
            };

            app.Contacts.Modify(newData);
        }
    }
}