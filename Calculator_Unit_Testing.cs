using Calculator_dl_example;
namespace Calculator_Unit_Testing
{
    [TestClass]
    public class Calculatortest
    {
        [TestMethod]
        public void Adding_two_numbers()
        {
            int num1 = 0, num2 = -1, expected=-1, actual ;
            Calculator_dl c = new Calculator_dl();
           actual= c.add(num1, num2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void subtracting_two_numbers()
        {
            int num1 = 0, num2 = -1, expected = 1, actual;
            Calculator_dl c = new Calculator_dl();
            actual = c.subtract(num1, num2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiplying_two_numbers()
        {
            int num1 = 1, num2 = 0, expected = 0, actual;
            Calculator_dl c = new Calculator_dl();
            actual = c.multiply(num1, num2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Dividing_two_numbers()
        {
            int num1 = 0, num2 = -1, expected = 0, actual;
            Calculator_dl c = new Calculator_dl();
            actual = c.divide(num1, num2);
            Assert.AreEqual(expected, actual);
            Assert.ThrowsException<System.DivideByZeroException>(() => c.divide(1, 0));
        }
    }
}