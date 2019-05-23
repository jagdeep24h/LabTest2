using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;


namespace CalcAppTest

{
    [TestFixture]
    class CalcTests
    {
        [Test]
        //Case 1
        public void GetAddition_Input6point46and5point44_Returns12point00()
        {

            //Arrange
            double number1 = 6.46;
            double number2 = 5.44;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        // Case 2
        public void GetAddition_Input112and140_Returns252()
        {

            //Arrange
            double number1 = 112;
            double number2 = 140;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        // Case 2
        public void GetAddition_Inputminus55and55_Returnsminus40()
        {

            //Arrange
            double number1 = -55;
            double number2 = 15;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}
