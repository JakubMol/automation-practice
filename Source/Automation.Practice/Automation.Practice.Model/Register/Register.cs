using System;
using Automation.Practice.Data.UserDetails;
using Automation.Practice.WebDriver;
using OpenQA.Selenium;

namespace Automation.Practice.Model.Register
{
    public class Register : IActorAction<ActionHelpers>
    {
        private UserDetails _userDetails;
        public Register(UserDetails userDetails)
        {
            _userDetails = userDetails;
        }

        public void Execute(ActionHelpers helpers)
        {
            helpers.SendKeys(By.Id("customer_firstname"), _userDetails.FirstName);
            helpers.SendKeys(By.Id("customer_lastname"), _userDetails.LastName);
            helpers.SendKeys(By.Id("email"), _userDetails.Email);
            helpers.SendKeys(By.Id("passwd"), _userDetails.Password);
            helpers.SendKeys(By.Id("firstname"), _userDetails.FirstName);
            helpers.SendKeys(By.Id("lastname"), _userDetails.LastName);
            helpers.SendKeys(By.Id("address1"), _userDetails.Address.AddressLine1);
            helpers.SendKeys(By.Id("address2"), _userDetails.Address.AddressLine2);
            helpers.SendKeys(By.Id("city"), _userDetails.Address.City);
            helpers.Select(By.Id("id_state"), _userDetails.Address.County);
            helpers.SendKeys(By.Id("postcode"), _userDetails.Address.PostCode);
            helpers.Select(By.Id("id_country"), _userDetails.Address.Country);
            helpers.SendKeys(By.Id("phone_mobile"), _userDetails.PhoneNumber);
        }
    }
}
