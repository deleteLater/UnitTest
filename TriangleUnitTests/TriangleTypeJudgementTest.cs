using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;
using TriangleTypeEvaluation;

namespace TriangleUnitTests
{
    [TestClass]
    public class TriangleTypeJudgementTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void Given_Valid_Input_Output_Right_TypeDescription()
        {
            // 期望结果 Arrange
            string common_triangle = "一般三角形";
            string isosceles_triangle = "等腰三角形";
            string right_triangle = "直角三角形";
            string equilateral_triangle = "等边三角形";
            // 测试用例
            TriangleDefinition com_triangle = new TriangleDefinition(2, 3, 4);
            TriangleDefinition iso_triangle = new TriangleDefinition(1, 2, 2);
            TriangleDefinition rig_triangle = new TriangleDefinition(3, 4, 5);
            TriangleDefinition equ_triangle = new TriangleDefinition(6, 6, 6);

            // 运行判定 Act and Assert
            TestContext.WriteLine(Evaluator.GetTriangleType(com_triangle));
            Assert.AreEqual(Evaluator.GetTriangleType(com_triangle), common_triangle);

            TestContext.WriteLine(Evaluator.GetTriangleType(iso_triangle));
            Assert.AreEqual(Evaluator.GetTriangleType(iso_triangle), isosceles_triangle);

            TestContext.WriteLine(Evaluator.GetTriangleType(rig_triangle));
            Assert.AreEqual(Evaluator.GetTriangleType(rig_triangle), right_triangle);

            TestContext.WriteLine(Evaluator.GetTriangleType(equ_triangle));
            Assert.AreEqual(Evaluator.GetTriangleType(equ_triangle), equilateral_triangle);
        }
    }
}
