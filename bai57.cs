using System;
using System.Text.Json;

public class Circle
{
    // Hàm tính toán và trả về kết quả dưới dạng JSON string
    public static string CalculateCircleProperties(double r)
    {
        double dienTich = Math.PI * r * r;
        double chuVi = 2 * Math.PI * r;
        double duongKinh = 2 * r;

        var result = new
        {
            dien_tich = dienTich,
            chu_vi = chuVi,
            duong_kinh = duongKinh
        };

        return JsonSerializer.Serialize(result);
    }

    public static void Main(string[] args)
    {
        double r;
        bool isValidInput = false;

        // Vòng lặp để nhập bán kính r, nếu nhập sai sẽ yêu cầu nhập lại
        do
        {
            Console.Write("Nhập bán kính r: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out r) && r > 0)
            {
                isValidInput = true;
            }
            else
            {
                Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập lại một số thực dương.");
            }
        } while (!isValidInput);

        // Gọi hàm để tính toán và hiển thị kết quả
        string resultJson = CalculateCircleProperties(r);
        Console.WriteLine("Kết quả: " + resultJson);
    }
}
