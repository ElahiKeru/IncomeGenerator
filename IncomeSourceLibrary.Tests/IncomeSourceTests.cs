using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IncomeSourceLibrary.Tests
{
    [TestClass]
    public class IncomeSourceTests
    {
        [TestMethod]
        public void Template()
        {
            //Arrange


            //Act


            //Assert
            Assert.IsTrue(true);
        }

        #region Adventurer
        #endregion

        #region Business
        [TestMethod]
        public void BusinessSimulation_Success()
        {
            //Arrange
            Business bus = new Business("Dormark Telormar", 10, 8, 35);

            //Act
            string result = bus.SimulateBusiness();

            //Assert
            Assert.IsTrue(!string.IsNullOrEmpty(result));
        }
        #endregion

        #region Mission
        [TestMethod]
        public void MissionSimulation_Success()
        {
            //Arrange
            AdventurerContainer advCon = new AdventurerContainer();
            advCon.Add(new Adventurer("Anders", 4));
            advCon.Add(new Adventurer("Kelrick", 3));
            advCon.Add(new Adventurer("Gubbur", 1));
            Mission miss = new Mission(100, 10, advCon.Container);

            //Act
            string result = miss.SimulateMission();

            //Assert
            Assert.IsTrue(!string.IsNullOrEmpty(result));
        }


        #endregion
    }
}
