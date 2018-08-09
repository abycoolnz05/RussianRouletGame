using System;
using System.IO;
using System.Media;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using  RussianRouletProject;
using RussianRouletProject.Properties;

namespace RussianRoulretUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        //Arrange
        public Form1 unitTest = new Form1();
        //Act
        private bool gameOver;
        int[] fireBullet = new int[6];
       
        int counter = 0;

        [TestMethod]
        public void TestMethod1()
        {
            //Assert           
            Assert.IsFalse(fireBullet[counter] == 1 && gameOver == false);
        }

        [TestMethod]
        public void TestMethod2()
        {         
            Assert.IsTrue(fireBullet[counter] == 0 && gameOver == false);
        }

        [TestMethod]
        public void TestMethod3()
        {
            SoundPlayer soundplayer = new SoundPlayer(Resources.Load);          
            Assert.IsTrue(soundplayer != null);                       
        }
       
    }
}
