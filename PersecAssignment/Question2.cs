using System.Text.RegularExpressions;

namespace PersecAssignment
{
  public class Question2
  {
    public string[] ReturnSortArray(string[] items)
    {
      var sorted = items
                .OrderBy(x => Regex.Match(x, @"^[a-zA-Z]+").Value) // ดึงตัวอักษรชุดแรกสุด (ใช้ ^ เพื่อการันตีว่าต้องขึ้นต้น) เช่น "TH"
                .ThenBy(x =>
                {
                  var match = Regex.Match(x, @"\d+");
                  return match.Success ? int.Parse(match.Value) : 0; // ดึงตัวเลขชุดแรกมาแปลงเป็น int ถ้าไม่มีให้เป็น 0
                })
                .ThenBy(x => x) // ถ้าหัวเท่ากัน เลขเท่ากัน ให้เก็บตกโดยเรียงตามตัวอักษรที่เหลือทั้งหมด (เช่น ตัว N ใน Netflix)
                .ToArray();

      return sorted;
    }
  }
}