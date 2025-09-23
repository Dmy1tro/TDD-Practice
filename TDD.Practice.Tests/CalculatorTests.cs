namespace TDD.Practice.Tests
{
    public class StringCalculatorTests
    {
        private StringCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new StringCalculator();
        }

        [Test]
        public void Add_EmptyString_ReturnsZero()
        {
            var result = _calculator.Add("");
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Add_SingleNumber_ReturnsThatNumber()
        {
            var result = _calculator.Add("5");
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Add_TwoNumbersSeparatedByComma_ReturnsSum()
        {
            var result = _calculator.Add("1,2");
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Add_MultipleNumbers_ReturnsSum()
        {
            var result = _calculator.Add("1,2,3,4");
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Add_NumbersSeparatedByNewlineAndComma_ReturnsSum()
        {
            var result = _calculator.Add("1\n2,3");
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Add_CustomDelimiter_ReturnsSum()
        {
            var result = _calculator.Add("//;\n1;2;3");
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Add_NegativeNumbers_ThrowsExceptionWithMessage()
        {
            var ex = Assert.Throws<ArgumentException>(() => _calculator.Add("1,-2,3,-4"));
            Assert.That(ex.Message.Contains("Negatives not allowed: -2, -4"), Is.True);
        }

        [Test]
        public void Add_NumbersGreaterThan1000_AreIgnored()
        {
            var result = _calculator.Add("2,1001");
            Assert.That(result, Is.EqualTo(2));
        }
    }
}