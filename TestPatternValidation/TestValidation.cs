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
        [Test]
        public void GivenInputIsString_WhenTestLastName_ShouldReturnLastName()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateLastName("Nelogal");
            Assert.AreEqual(actual, "Nelogal");
        }
        [Test]
        public void GivenInputIsString_WhenTestEmail_ShouldReturnEmail()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateEmail("megspn1998@gmail.com");
            Assert.AreEqual(actual, "megspn1998@gmail.com");
        }
        [Test]
        public void GivenInputIsString_WhenTestMobileNumber_ShouldReturnMobileNumber()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateMobileNumber("+91 6360139273");
            Assert.AreEqual(actual, "+91 6360139273");
        }
        [Test]
        public void GivenInputIsString_WhenTestPassword_ShouldReturnPassword()
        {
            Validation validation = new Validation();
            string actual = validation.ValidatePassword("abc@yahoo.com");
            Assert.AreEqual(actual, "abc@yahoo.com");
        }
        [Test]
        [TestCase("meghanelogal@gmail.com")]
        [TestCase("Meghaneloga##l33@gmail.com")]
        [TestCase("meGHanelogal@gmail.com.in")]
        [TestCase("megha12nelogal@gmail.com")]
        [TestCase("shaluelogal@gmail.com.in")]
        [TestCase("savita12nelogal@gmail.com")]
        public void GivenInputIsString_WhenTestEmail_ShouldReturnEmailParamerizedTest(string mailAddress)
        {
            Validation validation = new Validation();
            string actual = validation.ValidateEmailParametrized(mailAddress);
            Assert.AreEqual(actual, mailAddress);

        }
    }

}
