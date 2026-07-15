namespace PersecAssignment
{
  public class Question3
  {
    public string[] Autocomplete(string search, string[] items, int maxResults)
    {
      var result = items
          // ขั้นที่ 1 กรองเอาเฉพาะคำที่มีคำว่า search ซ่อนอยู่ (แบบไม่สนตัวพิมพ์เล็กใหญ่)
          .Where(x => x.Contains(search, StringComparison.OrdinalIgnoreCase))
          // ขั้นที่ 2 เรียงลำดับตามตำแหน่ง Index ที่เจอคำค้นหา 
          .OrderBy(x => x.IndexOf(search, StringComparison.OrdinalIgnoreCase))
          .Take(maxResults) // ดึงผลลัพธ์ออกตามจำนวน maxResults
          .ToArray();
      return result;
    }
  }
}