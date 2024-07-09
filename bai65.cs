using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    // Hàm ghi Dictionary ra file CSV có header
    public static void SaveDictionaryToCsvFile(Dictionary<string, double> dict, string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // Ghi header vào file CSV
                writer.WriteLine("Name,GPA");

                foreach (var kvp in dict)
                {
                    // Ghi Key và Value vào file CSV, phân cách bằng dấu phẩy
                    writer.WriteLine($"{kvp.Key},{kvp.Value}");
                }
            }
            Console.WriteLine("Dictionary successfully saved to CSV file with header.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void Main()
    {
        // Tạo một Dictionary với kiểu giá trị là số thực 8 byte
        var dict = new Dictionary<string, double>
        {
            { "Alice", 3.5 },
            { "Bob", 3.8 },
            { "Charlie", 2.9 }
        };

        // Gọi hàm để ghi Dictionary vào file CSV với tên file là "output.csv"
        SaveDictionaryToCsvFile(dict, "output.csv");
    }
}
