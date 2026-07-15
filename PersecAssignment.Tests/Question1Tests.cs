namespace PersecAssignment.Tests
{
  public class Question1Tests
  {
    [Fact]
    public void IsValidParentheses_ShouldReturnTrue_WhenMatchesCorrectly()
    {
      var question = new Question1();

      Assert.True(question.IsValidParentheses("()"));
      Assert.True(question.IsValidParentheses("([{ }])"));
    }

    [Fact]
    public void IsValidParentheses_ShouldReturnFalse_WhenMismatched()
    {
      var question = new Question1();

      Assert.False(question.IsValidParentheses("([{)"));
      Assert.False(question.IsValidParentheses(")"));
      Assert.False(question.IsValidParentheses("([)]"));
      Assert.False(question.IsValidParentheses("{"));
      Assert.False(question.IsValidParentheses("([[{ }]]])"));
    }
  }
}