using NUnit.Framework;
using PersonalLibrary.Validator;

namespace Test.UnitTests.Validator
{
    [TestFixture]
    public class ValidatorTests
    {
        [Test]
        [TestCase("Gadea")]
        [TestCase("D'Lilah")]
        [TestCase("Sarah-Jane")]
        public void IsValidName_ValidName_True(string name)
        {
            Assert.IsTrue(new Validators().IsValidName(name));
        }

        [Test]
        [TestCase("G")]
        [TestCase("S1")]
        [TestCase("@")]
        [TestCase("100")]
        [TestCase("?")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void IsValidName_InValidName_False(string name)
        {
            Assert.IsFalse(new Validators().IsValidName(name));
        }

        [Test]
        [TestCase("gz@gmail.com")]
        [TestCase("g1234@gmail.com")]
        [TestCase("s-12@gmail.com")]
        public void IsValidEmail_ValidEmail_True(string email)
        {
            Assert.IsTrue(new Validators().IsValidEmail(email));
        }

        [Test]
        [TestCase("com")]
        [TestCase("g")]
        [TestCase(".com")]
        [TestCase("@")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void IsValidEmail_InValidEmail_False(string email)
        {
            Assert.IsFalse(new Validators().IsValidEmail(email));
        }

        [Test]
        [TestCase("6150001234")]
        [TestCase("3058507700")]
        public void IsValidPhoneNumber_Valid_True(string phoneNumber)
        {
            Assert.IsTrue(new Validators().IsValidPhoneNumber(phoneNumber));
        }

        [Test]
        [TestCase("123456")]
        [TestCase("S1234GGTS")]
        [TestCase("*&")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void IsValidPhoneNumber_InValid_False(string phoneNumber)
        {
            Assert.IsFalse(new Validators().IsValidPhoneNumber(phoneNumber));
        }

        [Test]
        [TestCase("33186")]
        [TestCase("37128")]
        public void IsZipCodeValid_Valid_True(string zipCode)
        {
            Assert.IsTrue(new Validators().IsZipCodeValid(zipCode));
        }

        [Test]
        [TestCase("123456")]
        [TestCase("1")]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void IsZipCodeValid_InValid_False(string zipCode)
        {
            Assert.False(new Validators().IsZipCodeValid(zipCode));
        }
    }
}
