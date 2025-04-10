using Microsoft.VisualStudio.TestTools.UnitTesting;
using tk; 

namespace tk
{
    [TestClass]
    public class ExamCalculatorPositiveTests
    {
        [TestMethod]
        public void Calculate_MinValues_ReturnsGrade2()
        {
            // Указываем явный тип для деконструирования
            var result = ExamCalculator.CalculateResult(0, 0, 0);
            int total = result.total;
            string grade = result.grade;

            Assert.AreEqual(0, total);
            Assert.AreEqual("2 (неудовлетворительно)", grade);
        }

        [TestMethod]
        public void Calculate_MaxValues_ReturnsGrade5()
        {
            var result = ExamCalculator.CalculateResult(22, 38, 20);
            int total = result.total;
            string grade = result.grade;

            Assert.AreEqual(80, total);
            Assert.AreEqual("5 (отлично)", grade);
        }

        [TestMethod]
        public void Calculate_JustEnoughForGrade4()
        {
            var result = ExamCalculator.CalculateResult(10, 10, 12);
            int total = result.total;
            string grade = result.grade;

            Assert.AreEqual(32, total);
            Assert.AreEqual("4 (хорошо)", grade);
        }

        [TestMethod]
        public void Calculate_JustEnoughForGrade3()
        {
            var result = ExamCalculator.CalculateResult(5, 10, 6);
            int total = result.total;
            string grade = result.grade;

            Assert.AreEqual(21, total);
            Assert.AreEqual("3 (удовлетворительно)", grade);
        }

        [TestMethod]
        public void Calculate_JustEnoughForGrade5()
        {
            var result = ExamCalculator.CalculateResult(18, 20, 18);
            int total = result.total;
            string grade = result.grade;

            Assert.AreEqual(56, total);
            Assert.AreEqual("5 (отлично)", grade);
        }
    }
}
