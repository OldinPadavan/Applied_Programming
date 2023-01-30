namespace DemoApp.Tests
{
    public class DemoSolutionTests
    {
        private DemoSolution testSolution;
        [SetUp]
        public void Setup ( )
        {
            testSolution = new DemoSolution();
        }

        [Test]
        public void SumTest ( )
        {
            //Assign
            int value = 10;
            //Act
            int sum = testSolution.Sum(5, 5);
            //Assert
            Assert.That( sum, Is.EqualTo( value ));
            
        }

        [Test]
        public void getSqureTest()
        {
            //Assign
            int value = 64;
            //Act
            int squre = testSolution.getSqure(4);
            //Assert
            Assert.That(squre, Is.EqualTo(value));
        }
    }
}