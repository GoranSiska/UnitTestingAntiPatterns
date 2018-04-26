using Misspecification.TestClasses;
using NUnit.Framework;
using System;

namespace Misspecification
{
    [TestFixture]
    public class T01_Liar //Test unrelated code
    {
        [Test]
        public void Handle_Input_ReturnsHandledInput()
        {
            //Arrange
            var input = "2018/4/26";
            var dateConverter = new DateConverter();

            //Act
            var result = dateConverter.Convert(input);

            //Assert
            Assert.AreEqual(new DateTime(2018,4,26), result);
        }
    }
}
