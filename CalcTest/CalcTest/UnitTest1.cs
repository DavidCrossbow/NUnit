using NUnit.Framework;

namespace CalcTest
{
    public class Tests
    {
        [Test, Combinatorial]
        public void Test_Sum(
             [Range(0, 20)] double x,
             [Range(0, 20)] double y)
        {
            Calculator.Methods s = new Calculator.Methods();
            double a = s.addition(x, y);
            double r = x + y;
            Assert.AreEqual(r, a, "При X = {0}, Y = {1},\n  Результат сложения = {2},\n  Ожидаемый результат = {3}", x, y, a, r);
        }
        [Test, Combinatorial]
        public void Test_Diff(
            [Range(0, 20)] double x,
            [Range(0, 20)] double y)
        {
            Calculator.Methods s = new Calculator.Methods();
            double a = s.difference(x, y);
            double r = x - y;
            Assert.AreEqual(r, a, "При X = {0}, Y = {1},\n  Результат вычитания = {2},\n  Ожидаемый результат = {3}", x, y, a, r);
        }
        [Test, Combinatorial]
        public void Test_Mult(
            [Range(0, 20)] double x,
            [Range(0, 20)] double y)
        {
            Calculator.Methods s = new Calculator.Methods();
            double a = s.multiplication(x, y);
            double r = x * y;
            Assert.AreEqual(r, a, "При X = {0}, Y = {1},\n  Результат произведения = {2},\n  Ожидаемый результат = {3}", x, y, a, r);
        }
        [Test, Combinatorial]
        public void Test_Div(
            [Range(0, 20)] double x,
            [Range(0, 20)] double y)
        {
            Calculator.Methods s = new Calculator.Methods();
            double a = s.division(x, y);
            double r = x / y;
            Assert.AreEqual(r, a, "При X = {0}, Y = {1},\n  Результат деления = {2},\n  Ожидаемый результат = {3}", x, y, a, r);
        }      
    }
}