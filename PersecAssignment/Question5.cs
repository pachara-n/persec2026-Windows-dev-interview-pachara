namespace PersecAssignment
{
  public class Question5
  {
    public int SortDescending(int number)
    {
      int sortedNumber = int.Parse(string.Concat(number.ToString().OrderDescending()));
      return sortedNumber;
    }
  }
}