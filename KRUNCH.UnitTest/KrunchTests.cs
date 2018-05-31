namespace KRUNCH.UnitTest
{
    using System;

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
            var result = ValidString.Krunch();

            Console.WriteLine(result);
            //// Assert
            Assert.AreEqual("NW S TH M FR L GD C Y.", result);
        }
    }
}