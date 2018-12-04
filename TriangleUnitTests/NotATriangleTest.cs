using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTypeEvaluation;
using Triangle;

namespace TriangleUnitTests
{
    [TestClass]
    public class NotATriangleTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void Given_Invalid_Input_Output_Invalid_Input_Msg()
        {
            // Arrange
            // 期望结果 
            string excepted_msg = "非法三角形";
            // 测试用例
            List<TriangleDefinition> triangles = new List<TriangleDefinition>
            {
                new TriangleDefinition(0, 1, 2),
                new TriangleDefinition(-1, 2, 3),
                new TriangleDefinition(1, 1, 2)
            };

            // 运行判定 Act and Assert
            foreach (var triangle in triangles)
            {
                // 输出结果(便于查看)
                TestContext.WriteLine(Evaluator.GetTriangleType(triangle));
                // 判定
                Assert.AreEqual(excepted_msg, Evaluator.GetTriangleType(triangle));
            }
        }
    }
}
