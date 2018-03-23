using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void ShouldAssertTrue()
        {
            Assert.That(true, Is.EqualTo(true));
        }
    }
}
