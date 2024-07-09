using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    // Hàm đọc file CSV vào mảng 2 chiều các số thực, có thể có header hoặc không có header
    public static float[,] ReadCsvFileTo2DArray(string fileName, bool hasHeader = false)
    {
        try
        {
            // Đọc tất cả các dòng từ file CSV
            var lines = File.ReadAllLines(fileName);
            int rowCount = lines.Length;
            int colCount = lines[0].Split(',').Length;

            // Khởi tạo mảng 2 chiều với kích thước phù hợp
            float[,] array = new float[rowCount, colCount];

            int startLine = hasHeader ? 1 : 0;  // Nếu có header, bắt đầu đọc từ dòng thứ 1

            for (int i = startLine; i < rowCount + startLine; i++)
            {
                var values = lines[i - startLine].Split(',');

                for (int j = 0; j < colCount; j++)
                {
                    // Chuyển đổi giá trị chuỗi thành số thực 4 byte (float)
                    array[i - startLine, j] = float.Parse(values[j]);
                }
            }

            return array;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return null;  // Trả về null nếu có lỗi xảy ra
        }
    }

    static void Main()
    {
        // Gọi hàm để đọc file CSV vào mảng 2 chiều (có thể có header hoặc không có header)
        float[,] arrayWithHeader = ReadCsvFileTo2DArray("data_with_header.csv", true);
        float[,] arrayWithoutHeader = ReadCsvFileTo2DArray("data_without_header.csv", false);

        // Hiển thị mảng để kiểm tra kết quả
        Console.WriteLine("Array with header:");
        Print2DArray(arrayWithHeader);

        Console.WriteLine("\nArray without header:");
        Print2DArray(arrayWithoutHeader);
    }

    // Hàm hỗ trợ in mảng 2 chiều
    public static void Print2DArray(float[,] array)
    {
        if (array == null)
        {
            Console.WriteLine("Array is null.");
            return;
        }

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
