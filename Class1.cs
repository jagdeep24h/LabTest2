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
        // Case 3
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
        
            [Test]
        // Case 4
        public void GetSubtraction_Input55and15_Returnsminus35()
        {

            //Arrange
            double number1 = 50;
            double number2 = 15;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        // Case 5
        public void GetSubtraction_Input60point5and20point3_Returns40point2()
        {

            //Arrange
            double number1 = 60.5;
            double number2 = 20.3;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        // Case 6
        public void GetSubtraction_Inputminus10and5_Returnsminus15()
        {

            //Arrange
            double number1 = -10;
            double number2 = 5;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        // Case 7
        public void GetMultiplication_Input10and5_Returns50()
        {

            //Arrange
            double number1 = 10;
            double number2 = 5;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}
