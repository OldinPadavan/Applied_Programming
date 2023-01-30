using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace EducationPractice.UnitTests
{
    [TestClass]
    public class ProgramTests
    {
        
        [TestMethod]
        public void SumTest ( )
        {
            //Assign
            int a = 5;
            //Act
            int result = program.Sum(a);
            
            //Assert
            Assert.AreEqual(10, result);
        }
    }
}
