using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Test1()
        {
            FizzBuzzGame game = new FizzBuzzGame();

            //then
            Assert.NotNull(game);
        }

        [Fact]
        public void Should_return_the_number_given_when_count_off_given_normal_case_number()
        {
            //Given
            int givenNumber = 1;
            //When
            string result = FizzBuzzGame.CountOff(givenNumber);
            //Then
            FizzBuzzGame game = new FizzBuzzGame();

            //then
            Assert.Equal("1", result);
        }

    }
}