using NUnit.Framework;
using PatternValidation;

namespace TestPatternValidation
{
    public class Tests
    {

        [Test]
        public void GivenInputIsString_WhenTestFirstName_ShouldReturnFirstName()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateFirstName("Megha");
            Assert.AreEqual(actual, "Megha");
        }
    }
}