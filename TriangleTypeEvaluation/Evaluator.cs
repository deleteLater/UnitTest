using System;
using Triangle;

namespace TriangleTypeEvaluation
{
    public static class Evaluator
    {
        // 判断是否是三角形
        public static bool IsTriangle(TriangleDefinition triangle)
        {
            if (triangle.A <= 0 || triangle.B <= 0 || triangle.C <= 0 ||
                triangle.A + triangle.B <= triangle.C ||
                triangle.A + triangle.C <= triangle.B ||
                triangle.B + triangle.C <= triangle.A)
            {
                return false;
            }

            return true;
        }

        // 判断是否是直角三角形
        public static bool IsRightTriangle(TriangleDefinition triangle)
        {
            if (Math.Pow(triangle.A, 2) + Math.Pow(triangle.B, 2) == Math.Pow(triangle.C, 2) ||
                Math.Pow(triangle.A, 2) + Math.Pow(triangle.C, 2) == Math.Pow(triangle.B, 2) ||
                Math.Pow(triangle.B, 2) + Math.Pow(triangle.C, 2) == Math.Pow(triangle.A, 2))
            {
                return true;
            }

            return false;
        }

        // 判断是否是等边三角形
        public static bool IsEquilateralTriangle(TriangleDefinition triangle)
        {
            if (triangle.A == triangle.B && triangle.B == triangle.C)
            {
                return true;
            }

            return false;
        }

        // 判断是否是等腰三角形
        public static bool IsoscelesTriangle(TriangleDefinition triangle)
        {
            if (triangle.A == triangle.B || 
                triangle.B == triangle.C || 
                triangle.A == triangle.C &&
                !IsEquilateralTriangle(triangle))
            {
                return true;
            }

            return false;
        }

        // 获得三角形类型描述
        public static string GetTriangleType(TriangleDefinition triangle)
        {
            TriangleType type = TriangleType.CommonTriangle;

            // 判断类型
            if (!IsTriangle(triangle))
            {
                type = TriangleType.InvalidTriangle;
            }
            else if (IsRightTriangle(triangle))
            {
                type = TriangleType.RightTriangle;
            }
            else if (IsEquilateralTriangle(triangle))
            {
                type = TriangleType.EquilateralTriangle;
            }
            else if (IsoscelesTriangle(triangle))
            {
                type = TriangleType.IsoscelesTriangle;
            }

            // 返回类型描述字符串
            return type.GetDescription();
        }
    }
}
