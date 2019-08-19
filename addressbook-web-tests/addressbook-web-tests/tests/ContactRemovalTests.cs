using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            app.Contacts.Remove(1);
        }

        [Test]
        public void ContactRemoveOrCreateElement()
        {
            //Assert.IsTrue(app.Contacts.ContactIsPresent());
            app.Contacts.Remove(1);

        }
    }
}
