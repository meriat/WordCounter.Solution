using System;
using System.Collections.Generic;
using WordCounter.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTest
    {
        [TestMethod]
        public void IsWordEmpty_CheckIfInputIsValid_String()
        {
            //Arrange
            string input = "";
            string inputList="";
            WordChecker newCount = new WordChecker(input,inputList);
            
            //Act
             bool result = newCount.IsWordEmpty();
            
            //Assert
            Assert.AreEqual(true, result);

        
        }
        [TestMethod]
        public void IsWordEmpty_CheckIfListInputIsValid_String()
        {
            //Arrange
            string input = "hey";
            string inputList="";
            WordChecker newCount = new WordChecker(input,inputList);
            
            //Act
             bool result = newCount.IsWordEmpty();
            
            //Assert
            Assert.AreEqual(true, result);
            
        
        }
         [TestMethod]
        public void IsWordEmpty_CheckIfWordInputIsValid_String()
        {
            //Arrange
            string input = "";
            string inputList="hey";
            WordChecker newCount = new WordChecker(input,inputList);
            
            //Act
             bool result = newCount.IsWordEmpty();
            
            //Assert
            Assert.AreEqual(true, result);
            
        
        }
        [TestMethod]
        public void IsWordEmpty_CheckIfInputNotValid_String()
        {
            //Arrange
            string input = "hey";
            string inputList="hey";
            WordChecker newCount = new WordChecker(input,inputList);
            
            //Act
             bool result = newCount.IsWordEmpty();
            
            //Assert
            Assert.AreEqual(false, result);
            
        
        }
        [TestMethod]
        public void RepeatCounter_CheckIfInputAndListNotEqual_String()
        {
            //Arrange
            string input = "hello";
            string inputList="hey";
            WordChecker newCount = new WordChecker(input,inputList);
            
            //Act
             int result = newCount.RepeatCounter();
            
            //Assert
            Assert.AreEqual(0, result);
        
        }
        [TestMethod]
        public void RepeatCounter_CountNumberOfMatches_Integer()
        {
            //Arrange
            string input = "hello";
            string inputList="hello is hello my hello";
            WordChecker newCount = new WordChecker(input,inputList);
            
            //Act
             int result = newCount.RepeatCounter();
            
            //Assert
            Assert.AreEqual(3, result);
        
        }
        [TestMethod]
        public void RepeatCounter_CountMatchesOnlyExactinput_Integer()
        {
            //Arrange
            string input = "hello";
            string inputList="hey shammonahello ciao";
            WordChecker newCount = new WordChecker(input,inputList);
            
            //Act
             int result = newCount.RepeatCounter();
            
            //Assert
            Assert.AreEqual(0, result);
        
        }
        [TestMethod]
        public void RepeatCounter_CountMatchesOnlyExactinput1_Integer()
        {
            //Arrange
            string input = "shamonahello";
            string inputList = "hey hello";
            WordChecker newCount = new WordChecker(input,inputList);
            
            //Act
             int result = newCount.RepeatCounter();
            
            //Assert
            Assert.AreEqual(0, result);
        
        }
        [TestMethod]
        public void RepeatCounter_CheckIfInputAndListEmpty_Integer()
        {
            //Arrange
            string input = "";
            string inputList = "";
            WordChecker newCount = new WordChecker(input,inputList);
            
            //Act
             int result = newCount.RepeatCounter();
            
            //Assert
            Assert.AreEqual(-1, result);
        
        }
        
    }
}
