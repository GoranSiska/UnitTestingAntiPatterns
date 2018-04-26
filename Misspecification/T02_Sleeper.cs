using Misspecification.TestClasses;
using NUnit.Framework;
using System;

namespace Misspecification
{
    [TestFixture]
    public class T02_Sleeper //Designed to fail at specific point in time
    {
        [Test]
        public void Convert_Input_ReturnsConvertedInput()
        {
            //Arrange
            var now = DateTime.Now;
            var year = now.Year;
            var month = now.Month;
            var input = $"{year}/{month}/30";
            var dateConverter = new DateConverter();

            //Act
            var result = dateConverter.Convert(input);

            //Assert
            Assert.AreEqual(new DateTime(year,month,30), result);
        }
    }
}
