using SaveTheOcean;

namespace SaveTheOceanTests
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void TestNumberRescue()
        {
            // Arrange
            var tortoise = new Tortoise("Tortuga", "Tortuga de mar", 20.3, "12/2/2023", "BCN");

            // Act
            var result = tortoise.NumberRescue;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestRescueDate()
        {
            // Arrange
            var tortoise = new Tortoise("Tortuga", "Tortuga de mar", 20.3, "12/2/2023", "BCN");

            // Act
            var result = tortoise.RescueDate;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestSpecies()
        {
            // Arrange
            var tortoise = new Tortoise("Tortuga", "Tortuga de mar", 20.3, "12/2/2023", "BCN");

            // Act
            var result = tortoise.Species;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestAffectionDegree()
        {
            // Arrange
            var tortoise = new Tortoise("Tortuga", "Tortuga de mar", 20.3, "12/2/2023", "BCN");

            // Act
            var result = tortoise.AffectionDegree;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestLocation()
        {
            // Arrange
            var tortoise = new Tortoise("Tortuga", "Tortuga de mar", 20.3, "12/2/2023", "BCN");

            // Act
            var result = tortoise.Location;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestName()
        {
            // Arrange
            var tortoise = new Tortoise("Tortuga", "Tortuga de mar", 20.3, "12/2/2023", "BCN");

            // Act
            var result = tortoise.Name;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestWeight()
        {
            // Arrange
            var tortoise = new Tortoise("Tortuga", "Tortuga de mar", 20.3, "12/2/2023", "BCN");

            // Act
            var result = tortoise.Weight;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestGenerateRescueNumber()
        {
            // Arrange
            string expectedPrefix = "RES";
            Random random = new Random();

            // Act
            string result = Animal.GenerateRescueNumber();

            // Assert
            Assert.IsTrue(result.StartsWith(expectedPrefix));
            Assert.AreEqual(6, result.Length); 
        }

    }

}
