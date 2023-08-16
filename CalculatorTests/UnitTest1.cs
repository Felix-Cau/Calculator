using Calculator;

namespace CalculatorTests
{
    public class CalculationsTest
    {
        [Fact]
        public void DoesCalculationWork()
        {
            //Arrange
            Result x = new();
            x.Value = 2;
            
            Result y = new();
            y.Value = 3;
            
            Result addResult = new();

            Result expectedResult = new();
            expectedResult.Value = 5;

            //Act
            addResult = Calculations.Add(x.Value, y.Value);

            //Assert
            Assert.Equal(expectedResult.Value, addResult.Value);
        }

        [Fact]
        public void DoesSubtracionWork()
        {
            //Arrange
            Result x = new();
            x.Value = 3;

            Result y = new();
            y.Value = 2;

            Result expectedResult = new();
            expectedResult.Value = 1;

            //Act
            Result subtractResult = Calculations.Subtract(x.Value,y.Value);

            //Assert
            Assert.Equal(expectedResult.Value, subtractResult.Value);
        }

        [Fact]
        public void DoesMultiplyWork()
        {
            //Arrange
            Result x = new();
            x.Value = 3;

            Result y = new();
            y.Value = 2;

            Result expectedResult = new();
            expectedResult.Value = 6;

            //Act
            Result multiplyResult = Calculations.Multiply(x.Value, y.Value);

            //Assert
            Assert.Equal(expectedResult.Value, multiplyResult.Value);
        }

        [Fact]
        public void DoesDivideWork()
        {
            //Arrange
            Result x = new();
            x.Value = 4;

            Result y = new();
            y.Value = 2;

            Result expectedResult = new();
            expectedResult.Value = 2;

            //Act
            Result divideResult = Calculations.Divide(x.Value, y.Value);

            //Assert
            Assert.Equal(expectedResult.Value, divideResult.Value);
        }

        [Fact]
        public void DoesDivideErrorMessageWork()
        {
            Result x = new();
            x.Value = 3;
            Result y = new();
            y.Value = 0;

            //Act
            Result divideResult = Calculations.Divide(x.Value, y.Value);

            //Assert
            Assert.NotNull(divideResult.Message);
        }

    }
}