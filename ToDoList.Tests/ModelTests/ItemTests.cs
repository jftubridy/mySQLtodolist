using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.TestTools
{
    [TestClass]
    public class ItemControllerTest
    {

        [TestMethod]
        public void Find_ReturnsCorrectItem_Item()
        {
            //Arrange
            string description01 = "Walk the dog";
            string description02 = "Wash the dishes";
            Item newItem1 = new Item(description01);
            Item newItem2 = new Item(description02);

            //Act
            Item result = Item.Find(2);

            //Assert
            Assert.AreEqual(newItem2, result);
        }
    }
}