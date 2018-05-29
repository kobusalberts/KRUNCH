namespace UnitTest.KRUNCH
{
    using System;
    using System.Linq;

    using Krunch.DomainLogic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The "krunch" tests.
    /// </summary>
    [TestClass]
    public class KrunchTests
    {

        [TestMethod]
        public void IsInputValid()
        {
            //// Arrange 
            var ValidString = @"NOW IS THE TIME FOR ALL GOOD MEN TO COME TO THE AID OF THEIR COUNTRY.";

            //// Act 
            var result = KrunchProcessor.Krunch(ValidString);

            Console.WriteLine(result);
            //// Assert
            Assert.AreEqual("NW S TH M FR L GD C Y.", result);
        }

        ///// <summary>
        /////     Test if the char is invalid.
        ///// </summary>
        //[TestMethod]
        //public void IsInputNotValid()
        //{
        //    //// Arrange 
        //    var InValidString = @"Bla Bla @#$%@";

        //    //// Act 
        //    var result = this.validChars.FirstOrDefault(x => x.Equals(InValidString));

        //    //// Assert
        //    Assert.AreEqual(default(char), result);
        //}

    }
}