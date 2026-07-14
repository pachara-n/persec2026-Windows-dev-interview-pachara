namespace PersecAssignment
{
  public class Question1
  {
    public bool IsValidParentheses(string s)
    {
      Stack<char> stack = new Stack<char>();

      foreach (char c in s)
      {
        // ถ้าเจอวงเล็บเปิด ให้ push เข้า stack
        if ( c == '(' || c == '[' || c == '{' )
        {
          stack.Push(c);
        }
        // เช็ควงเล็บปิดทีละประเภท
        else if (c == ')')
        {
          if (stack.Count == 0)
          {
            return false;
          }
          if (stack.Peek() == '(')
          {
            stack.Pop();
          } else
          {
            return false;
          }
        } else if (c == ']')
        {
          if (stack.Count == 0)
          {
            return false;
          }
          if (stack.Peek() == '[')
          {
            stack.Pop();
          } else
          {
            return false;
          }
        } else if (c == '}')
        {
          if (stack.Count == 0)
          {
            return false;
          }
          if (stack.Peek() == '{')
          {
            stack.Pop();
          } else
          {
            return false;
          }
        }
      }
      return stack.Count == 0;
    }
  }
}