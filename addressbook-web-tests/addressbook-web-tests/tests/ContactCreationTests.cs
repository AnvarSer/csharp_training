﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {

        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData();
            contact.Firstname = "Anvar";
            contact.Lastname = "Serojitdinov";

            app.Contacts.Create(contact);
        }
    }
}
