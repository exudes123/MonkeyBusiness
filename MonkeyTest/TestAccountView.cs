﻿using MonkeyBusiness.Models;
using MonkeyBusiness.Views;
using MonkeyBusiness.Handler;
using MonkeyBusiness.Models;
using MonkeyBusiness.Views;

namespace MonkeyTest
{
    [TestClass]
    public class TestAccountView
    {
        [TestMethod]
        public void TestGetCategory()
        {
            //Arrange 
            AccountView SUT = new AccountView();
            List<Category> categories = new List<Category>();
            Category category = new Category(0, "Toys");
            Category category2 = new Category(1, "Food");
            Category category3 = new Category(2, "Taxes");
            categories.Add(category);
            categories.Add(category2);
            categories.Add(category3);
            int choice = 2;
            //Act 
            Category Actual = SUT.GetCategory(choice, categories);
            //Assert
            Assert.AreSame(category3, Actual);
        }

       
    }

}

