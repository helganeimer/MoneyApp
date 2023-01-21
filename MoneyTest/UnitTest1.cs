using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoneyLibrary;


namespace MoneyWorkTest
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void Set_Money_With_Invalid_Count_Should_Throw_ArgumentOutOfRangeException()
        {
            //Arrange
            double count = -2341;
            Money money = new Money();

            //Act and Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => money.Count = count);

        }
        [TestMethod]
        public void Set_Money_With_Invalid_Code_Should_Throw_ArgumentOutOfRangeException()
        {
            //Arrange
            string code = "UAHS";
            Money money = new Money();

            //Act and Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => money.Code = code);

        }
        [TestMethod]
        public void Set_Money_With_Invalid_DollarRate_Should_Throw_ArgumentOutOfRangeException()
        {
            //Arrange
            double dollar_rate = 0;
            Money money = new Money();

            //Act and Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => money.DollarRate = dollar_rate);

        }
        [TestMethod]
        public void Money_With_Valid_Comparison()
        {
            //Arrange
            double count1 = 24531.82;
            double count2 = 1923.71;
            string expected = (count1 + " greater than " + count2);
            Money money1 = new Money();
            Money money2 = new Money();

            //Act
            money1.Count = count1;
            money2.Count = count2;
            string actual = money1.CountsComparison(money2);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Money_With_Valid_Comparison_Equal()
        {
            //Arrange
            double count1 = 4531.8;
            double count2 = 4531.8;
            string expected = ("Counts are equal");
            Money money1 = new Money();
            Money money2 = new Money();

            //Act
            money1.Count = count1;
            money2.Count = count2;
            string actual = money1.CountsComparison(money2);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Money_With_Valid_Sum_Of_Counts()
        {
            //Arrange
            double count1 = 2453.8;
            double count2 = 923.7;
            double expected = 3377.5;
            Money money1 = new Money();
            Money money2 = new Money();

            //Act
            money1.Count = count1;
            money2.Count = count2;
            double actual = money1.SumOfCounts(money2);

            //Assert
            Assert.AreEqual(expected, actual, "Sum wasn't calculated correctly");

        }
        [TestMethod]
        public void Money_With_Valid_Count_In_Dollars()
        {
            //Arrange
            double count = 2341.9;
            double dollar_rate = 0.049;
            double expected = 114.753;
            Money money = new Money();

            //Act
            money.Count = count;
            money.DollarRate = dollar_rate;
            double actual = money.CountInDollar();

            //Assert
            Assert.AreEqual(expected, actual, 0.001, "Count in dollars wasn't calculated correctly");

        }
    }
}
