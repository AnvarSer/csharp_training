﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager)
            : base(manager)
        {
        }

        internal void Remove(object newData)
        {
            throw new NotImplementedException();
        }

        public ContactHelper Create(ContactData contact)
        {
            manager.Navigator.GoToContactsPage();

            AddNewContact();
            FillContactForm(contact);
            SubmitContactCreation();
            return this;
        }

        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public ContactHelper AddNewContact()
        {
            driver.FindElement(By.XPath("//*[@id='nav']/ul/li[2]/a")).Click();
            return this;
        }

        public ContactHelper Modify(ContactData newData)
        {
            manager.Navigator.GoToContactsPage();
            ClickEditContact();
            FillContactForm(newData);
            UpdateContactModification();
            ReturnToHomePage();
            return this;
        }

        private ContactHelper FillContactForm(ContactData contact)
        {
            Type(By.Name("firstname"), contact.Firstname);
            Type(By.Name("lastname"), contact.Lastname);
            return this;
        }

        public ContactHelper ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
            return this;
        }

        public ContactHelper UpdateContactModification()
        {
            driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/form[1]/input[22]")).Click();
            return this;
        }

        public ContactHelper ModifyLastName(ContactData contact)
        {
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.Lastname);
            return this;
        }

        public ContactHelper ModifyFirstName(ContactData contact)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.Firstname);
            return this;
        }

        public ContactHelper ClickEditContact()
        {
            driver.FindElement(By.XPath("//*[@id='maintable']/tbody/tr[2]/td[8]/a/img")).Click();
            return this;
        }

        public ContactHelper Remove(int p)
        {
            manager.Navigator.GoToContactsPage();
            SelectContact(p);
            RemoveContact();
            ReturnToContactsPage();
            return this;
        }

        public ContactHelper ReturnToContactsPage()
        {
            driver.FindElement(By.LinkText("home")).Click();
            return this;
        }

        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//*[@id='content']/form[2]/div[2]/input")).Click();
            driver.SwitchTo().Alert().Accept();
            return this;
        }

        public ContactHelper SelectContact(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }
    }
}







