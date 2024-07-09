using System;
using System.IO;

class Program
{
    // Hàm ghi mảng 2 chiều các số thực ra file CSV không có header
    public static void Save2DArrayToCsvFile(float[,] array, string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                int rows = array.GetLength(0);
                int cols = array.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        writer.Write(array[i, j]);

                        if (j < cols - 1)
                        {
                            writer.Write(",");  // Thêm dấu phân cách giữa các cột
                        }
                    }
                    writer.WriteLine();  // Thêm dòng mới sau mỗi hàng
                }
            }
            Console.WriteLine("Array successfully saved to CSV file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void Main()
    {
        // Tạo một mảng 2 chiều các số thực
        float[,] array = new float[,]
        {
            { 1.1f, 2.2f, 3.3f },
            { 4.4f, 5.5f, 6.6f },
            { 7.7f, 8.8f, 9.9f }
        };

        // Gọi hàm để ghi mảng 2 chiều vào file CSV
        Save2DArrayToCsvFile(array, "output.csv");
    }
}
