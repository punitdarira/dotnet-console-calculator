namespace Calculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void TestAdd()
    {
        Assert.Equal(6L, Add.Eval(1L, 5L));
    }
    //
    [Fact]
    public void Eval_AddsTwoPositiveNumbers_ReturnsCorrectResult()
    {
        // Given
        float lhs = 5.0f;
        float rhs = 3.0f;
        
        // When
        float result = Add.Eval(lhs, rhs);
        
        // Then
        Assert.Equal(8.0f, result);
    }

    [Fact]
    public void Eval_AddsNumberAndZero_ReturnsSameNumber()
    {
        // Given
        float lhs = 7.5f;
        float rhs = 0.0f;
        
        // When
        float result = Add.Eval(lhs, rhs);
        
        // Then
        Assert.Equal(7.5f, result);
    }

    [Fact]
    public void Eval_AddsPositiveAndNegativeNumber_ReturnsCorrectResult()
    {
        // Given
        float lhs = 5.5f;
        float rhs = -2.5f;
        
        // When
        float result = Add.Eval(lhs, rhs);
        
        // Then
        Assert.Equal(3.0f, result);
    }
    //
    [Fact]
    public void Eval_MultipliesTwoPositiveNumbers_ReturnsCorrectResult()
    {
        // Given
        float lhs = 5.0f;
        float rhs = 3.0f;
        
        // When
        float result = Multiply.Eval(lhs, rhs);
        
        // Then
        Assert.Equal(15.0f, result);
    }

    [Fact]
    public void Eval_MultipliesNumberByZero_ReturnsZero()
    {
        // Given
        float lhs = 7.5f;
        float rhs = 0.0f;
        
        // When
        float result = Multiply.Eval(lhs, rhs);
        
        // Then
        Assert.Equal(0.0f, result);
    }

    [Fact]
    public void Eval_MultipliesPositiveAndNegativeNumber_ReturnsCorrectResult()
    {
        // Given
        float lhs = 5.5f;
        float rhs = -2.0f;
        
        // When
        float result = Multiply.Eval(lhs, rhs);
        
        // Then
        Assert.Equal(-11.0f, result);
    }
    
    [Fact]
    public void Eval_DividesTwoPositiveNumbers_ReturnsCorrectResult()
    {
        // Arrange
        float numerator = 10.0f;
        float denominator = 2.0f;
        
        // Act
        float result = Divide.Eval(numerator, denominator);
        
        // Assert
        Assert.Equal(5.0f, result);
    }

    [Fact]
    public void Eval_DividesNumberByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        float numerator = 7.5f;
        float denominator = 0.0f;
        
        // Act & Assert
        Assert.Equal(float.PositiveInfinity, Divide.Eval(numerator, denominator));
    }

    [Fact]
    public void Eval_DividesPositiveByNegativeNumber_ReturnsNegativeResult()
    {
        // Arrange
        float numerator = 9.0f;
        float denominator = -3.0f;
        
        // Act
        float result = Divide.Eval(numerator, denominator);
        
        // Assert
        Assert.Equal(-3.0f, result);
    }

    [Fact]
    public void TestMult()
    {
        Assert.Equal(6L, Multiply.Eval(2L, 3L));
    }
    [Fact]
    public void TestAddOperation()
    {
        Assert.Equal(8, Evaluator.Eval("+", 6, 2));
    }
    [Fact]
    public void TestMultiplyOperation()
    {
        Assert.Equal(12, Evaluator.Eval("*", 6, 2));
    }
    [Fact]
    public void TestDivideOperation()
    {
        Assert.Equal(3, Evaluator.Eval("/", 6, 2));
    }
    [Fact]
    public void TestDefaultOperation()
    {
        var ex = Assert.Throws<Exception>(() => Evaluator.Eval("&", 6, 2));
        Assert.Equal("unimplemented", ex.Message);
    }

    // new test cases below
    [Fact]
    public void TestExponential(){
        // Assuming Exponential.Eval takes double and returns double
        Assert.Equal(8, Exponential.Eval(2, 3), 2);
    }

    [Fact]
    public void TestSquareRoot(){
        // Assuming SquareRoot.Eval takes and returns double
        Assert.Equal(4, SquareRoot.Eval(16), 2);
    }

    [Fact]
    public void TestSine(){
        // Assuming Sine.Eval takes radians as double and returns double
        Assert.Equal(1, Sine.Eval(Math.PI / 2), 2);
    }

    [Fact]
    public void TestCosine(){
        // Assuming Cosine.Eval takes radians as double and returns double
        Assert.Equal(-1, Cosine.Eval(Math.PI), 2);
    }

    [Fact]
    public void TestTangent(){
        // Assuming Tangent.Eval takes radians as double and returns double
        // Note: Tangent of PI/4 is 1, but due to floating point precision, a delta is used
        Assert.Equal(1, Tangent.Eval(Math.PI / 4), 2);
    }

    [Fact]
    public void TestFactorial(){
        // Assuming Factorial.Eval takes and returns long
        Assert.Equal(120, Factorial.Eval(5));
    }

}