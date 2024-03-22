namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddObject()
        {
            // Arrange
            Backpack myBackpack = new Backpack("Black", "Nike", "Nylon", 1.5, 20);
            myBackpack.SubscribeToAddObjectEvent();

            // Act
            myBackpack.AddObject("Laptop", 3);

            // Assert
            Assert.AreEqual(1, myBackpack.Contents.Count);
            Assert.AreEqual(17, myBackpack.Volume);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestVolumeExceeded()
        {
            // Arrange
            Backpack myBackpack = new Backpack("Black", "Nike", "Nylon", 1.5, 5);
            myBackpack.SubscribeToAddObjectEvent();

            // Act
            myBackpack.AddObject("Guitar", 15);
        }
    }
}