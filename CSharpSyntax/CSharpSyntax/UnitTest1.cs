namespace CSharpSyntax
{
    public class UnitTest1
    {
        [Fact] // Attributes
        public void TestDivisionOperatorOnIntegers()
        {
            // Given (Arrange)
            int a = 30, b = 10, answer;
            // When (Act)
            answer = a / b; // "System Under Test (SUT)"
            // Then (Assert)
            Assert.Equal(3, answer);

        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(10, 5, 15)]
        [InlineData(13, 3, 16)]
        public void CanAddAnyTwoIntegers(int a, int b, int expected)
        {
            int answer = a + b;
            Assert.Equal(expected, answer);
        }
    }
}