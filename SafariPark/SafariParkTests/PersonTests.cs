using NUnit.Framework;
using SafariParkApp;

namespace SafariParkTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Alex", "Rae", "Alex Rae")]
        [TestCase("", "", " ")]
        public void GetFullNameTest(string fName, string lName, string expected)
        {
            var subject = new Person(fName, lName);
            var result = subject.GetFullName();
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void AgeTest()
        {
            var subject = new Person("A", "B");
            subject.Age = 35;
            Assert.AreEqual(35, subject.Age);
        }

        [TestCase("","","")]
        public void PointTest(int x, int y, int z, int expected)
        {
            var subject = new Program.Point3D(x, y, z);
            Assert.AreEqual(expected, subject);
        }

        
    }
}