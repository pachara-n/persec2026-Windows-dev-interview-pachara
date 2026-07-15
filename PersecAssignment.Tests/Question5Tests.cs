namespace PersecAssignment.Tests
{
    public class Question5Tests
    {
        [Fact]
        public void SortDescending_ShouldReturnCorrectNumber()
        {
            var question5 = new Question5();

            Assert.Equal(8300, question5.SortDescending(3008));
            Assert.Equal(9981, question5.SortDescending(1989));
            Assert.Equal(9762, question5.SortDescending(2679));
            Assert.Equal(9631, question5.SortDescending(9163));
        }
    }
}