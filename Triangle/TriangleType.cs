using System.ComponentModel;

namespace Triangle
{
    public enum TriangleType
    {
        [Description("一般三角形")]
        CommonTriangle,

        [Description("直角三角形")]
        RightTriangle,

        [Description("等腰三角形")]
        IsoscelesTriangle, 

        [Description("等边三角形")]
        EquilateralTriangle, 

        [Description("非法三角形")]
        InvalidTriangle
    };
}