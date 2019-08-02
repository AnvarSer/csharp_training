using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests : TestBase
    {
        private object newData;

        [Test]
        public void ContactRemovalTest()
        {
            app.Contacts.Remove(1, newData);
        }
    }
}
