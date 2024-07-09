Dưới đây là hướng dẫn chi tiết để viết một hàm **static** trong C# ghi một `Dictionary` ra file JSON, cùng với hai cách khác nhau để thực hiện việc này. Cả hai cách đều sử dụng thư viện `System.Text.Json` hoặc `Newtonsoft.Json` (Json.NET) và hàm sẽ trả về một giá trị cho biết thành công hay thất bại của việc ghi file.

### **1. Sử dụng `System.Text.Json`**

**Hàm Static:**

```csharp
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    // Cách 1: Hàm ghi Dictionary ra file JSON và trả về bool
    public static bool SaveDictionaryToJsonFile(Dictionary<string, int> dict, string fileName)
    {
        try
        {
            // Chuyển đổi Dictionary thành JSON string
            string jsonString = JsonSerializer.Serialize(dict, new JsonSerializerOptions { WriteIndented = true });

            // Ghi JSON string ra file
            File.WriteAllText(fileName, jsonString);
            return true; // Trả về true nếu ghi thành công
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return false; // Trả về false nếu có lỗi
        }
    }

    // Cách 2: Hàm ghi Dictionary ra file JSON và trả về void
    public static void SaveDictionaryToJsonFileWithVoid(Dictionary<string, int> dict, string fileName)
    {
        try
        {
            // Chuyển đổi Dictionary thành JSON string
            string jsonString = JsonSerializer.Serialize(dict, new JsonSerializerOptions { WriteIndented = true });

            // Ghi JSON string ra file
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine("Dictionary successfully saved to JSON file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void Main()
    {
        // Tạo một Dictionary để ghi ra file JSON
        var dict = new Dictionary<string, int>
        {
            { "key1", 10 },
            { "key2", 20 },
            { "key3", 30 }
        };

        // Cách 1: Gọi hàm và kiểm tra kết quả trả về
        bool success = SaveDictionaryToJsonFile(dict, "output1.json");
        Console.WriteLine($"SaveDictionaryToJsonFile result: {success}");

        // Cách 2: Gọi hàm và không kiểm tra kết quả trả về
        SaveDictionaryToJsonFileWithVoid(dict, "output2.json");
    }
}
```

**Chạy chương trình** sẽ tạo hai file JSON với tên `output1.json` và `output2.json` trong thư mục làm việc hiện tại. Nếu có lỗi xảy ra trong quá trình ghi file, thông báo lỗi sẽ được hiển thị trên console.

### **2. Sử dụng `Newtonsoft.Json` (Json.NET)**

**Cài đặt Newtonsoft.Json qua NuGet:**

```bash
dotnet add package Newtonsoft.Json
```

**Hàm Static:**

```csharp
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program
{
    // Cách 1: Hàm ghi Dictionary ra file JSON và trả về bool
    public static bool SaveDictionaryToJsonFile(Dictionary<string, int> dict, string fileName)
    {
        try
        {
            // Chuyển đổi Dictionary thành JSON string
            string jsonString = JsonConvert.SerializeObject(dict, Formatting.Indented);

            // Ghi JSON string ra file
            File.WriteAllText(fileName, jsonString);
            return true; // Trả về true nếu ghi thành công
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return false; // Trả về false nếu có lỗi
        }
    }

    // Cách 2: Hàm ghi Dictionary ra file JSON và trả về void
    public static void SaveDictionaryToJsonFileWithVoid(Dictionary<string, int> dict, string fileName)
    {
        try
        {
            // Chuyển đổi Dictionary thành JSON string
            string jsonString = JsonConvert.SerializeObject(dict, Formatting.Indented);

            // Ghi JSON string ra file
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine("Dictionary successfully saved to JSON file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void Main()
    {
        // Tạo một Dictionary để ghi ra file JSON
        var dict = new Dictionary<string, int>
        {
            { "key1", 10 },
            { "key2", 20 },
            { "key3", 30 }
        };

        // Cách 1: Gọi hàm và kiểm tra kết quả trả về
        bool success = SaveDictionaryToJsonFile(dict, "output1.json");
        Console.WriteLine($"SaveDictionaryToJsonFile result: {success}");

        // Cách 2: Gọi hàm và không kiểm tra kết quả trả về
        SaveDictionaryToJsonFileWithVoid(dict, "output2.json");
    }
}
```

**Chạy chương trình** sẽ tạo hai file JSON với tên `output1.json` và `output2.json` trong thư mục làm việc hiện tại. Nếu có lỗi xảy ra trong quá trình ghi file, thông báo lỗi sẽ được hiển thị trên console.

### **3. Giải thích**

- **`SaveDictionaryToJsonFile` (Cả hai cách)**:
  - **Cách 1**: Hàm này chuyển đổi `Dictionary` thành JSON và ghi vào file, đồng thời trả về `bool` để báo cho người gọi biết việc ghi file có thành công hay không.
  - **Cách 2**: Hàm này thực hiện cùng một chức năng nhưng không trả về giá trị gì. Thay vào đó, nó in ra thông báo cho người dùng biết rằng file JSON đã được ghi thành công hoặc không.

### **4. Nội dung JSON File**

Dưới đây là nội dung của file JSON tạo ra từ các ví dụ trên:

**`output1.json` và `output2.json`:**

```json
{
  "key1": 10,
  "key2": 20,
  "key3": 30
}
```



