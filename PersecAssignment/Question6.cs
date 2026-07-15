namespace PersecAssignment
{
  public class Question6
  {
    public int[] Tribonacci(int[] signature, int n)
    {

      List<int> result = signature.ToList();

      // ถ้าค่าเริ่มต้นยาวเกินกว่าจำนวนที่อยากได้ (n) ให้ตัดเอาแค่ n ตัวแรก
      if (result.Count > n)
      {
        return result.Take(n).ToArray();
      }

      // ลูปคำนวณหาตัวถัดไปเรื่อย ๆ จนกว่าความยาว List จะครบตามจำนวนที่อยากได้ (n)
      while (result.Count < n)
      {
        // เอา 3 ตัวท้ายสุด ณ ปัจจุบันใน List มาบวกกัน
        int nextNumber = result[result.Count - 1] + result[result.Count - 2] + result[result.Count - 3];
        result.Add(nextNumber);
      }

      return result.ToArray();
    }
  }
}