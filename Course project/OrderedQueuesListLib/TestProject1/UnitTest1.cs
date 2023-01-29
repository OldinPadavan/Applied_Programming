namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreatingList ( )
        {
            //arrange
            OrdereLinkedListLibrary testList = new OrdereLinkedListLibrary();
            //act
            testList.Add(new Queue(string));
            //asserts
            testList.isEmpty().ShouldBeFalse();
        }
    }
}