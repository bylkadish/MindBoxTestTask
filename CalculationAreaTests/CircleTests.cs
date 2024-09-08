using CalculationArea;

namespace CalculationAreaTests;

internal class CircleTests
{
    [Test]
    public void CalculateArea_Circle_SuccessfulTest()
    {
        var circle = new Circle(5);
        //Assert.AreEqual(Math.PI * 25, circle.CalculateArea(), 1e-11);
        Assert.That(Math.PI * 25, Is.EqualTo(circle.CalculateArea()));
    }
}