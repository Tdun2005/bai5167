

### **1. Dictionary Lồng Nhau trong C#**

**Dictionary lồng nhau** là một `Dictionary` chứa các `Dictionary` khác làm giá trị. Đây là cách rất hiệu quả để tổ chức dữ liệu có nhiều cấp độ phân cấp. 

Dưới đây là ví dụ về `Dictionary` lồng nhau và cách chuyển đổi giữa `Dictionary` và `JSON` để bạn có thể hiểu rõ hơn về cách tổ chức và chuyển đổi dữ liệu.

#### **Ví dụ về Dictionary Lồng Nhau**

```csharp
using System;
using System.Collections.Generic;
using System.Text.Json;

class Program
{
    static void Main()
    {
        // Tạo một Dictionary lồng nhau
        var students = new Dictionary<string, Dictionary<string, double>>
        {
            { "Alice", new Dictionary<string, double> { { "Math", 85.5 }, { "English", 90.0 } } },
            { "Bob", new Dictionary<string, double> { { "Math", 78.0 }, { "English", 82.5 } } },
            { "Charlie", new Dictionary<string, double> { { "Math", 92.0 }, { "English", 88.5 } } }
        };

        // Chuyển đổi Dictionary lồng nhau thành JSON string
        string jsonString = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine("Dictionary to JSON:");
        Console.WriteLine(jsonString);

        // Chuyển đổi JSON string thành Dictionary lồng nhau
        var deserializedStudents = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, double>>>(jsonString);
        Console.WriteLine("\nJSON to Dictionary:");
        foreach (var student in deserializedStudents)
        {
            Console.WriteLine($"{student.Key}:");
            foreach (var subject in student.Value)
            {
                Console.WriteLine($"  {subject.Key}: {subject.Value}");
            }
        }
    }
}
```

**Kết quả Console:**

```
Dictionary to JSON:
{
  "Alice": {
    "Math": 85.5,
    "English": 90.0
  },
  "Bob": {
    "Math": 78.0,
    "English": 82.5
  },
  "Charlie": {
    "Math": 92.0,
    "English": 88.5
  }
}

JSON to Dictionary:
Alice:
  Math: 85.5
  English: 90.0
Bob:
  Math: 78.0
  English: 82.5
Charlie:
  Math: 92.0
  English: 88.5
```

### **2. Nội dung JSON tương ứng với Dictionary Lồng Nhau**

**Nội dung của file JSON tương ứng** với `Dictionary` lồng nhau trong ví dụ trên:

```json
{
  "Alice": {
    "Math": 85.5,
    "English": 90.0
  },
  "Bob": {
    "Math": 78.0,
    "English": 82.5
  },
  "Charlie": {
    "Math": 92.0,
    "English": 88.5
  }
}
```

### **3. Cách chuyển đổi giữa Dictionary Lồng Nhau và JSON**

Dưới đây là mã nguồn minh họa cách chuyển đổi giữa `Dictionary` lồng nhau và JSON, sử dụng thư viện `System.Text.Json`.

#### **Chuyển đổi Dictionary thành JSON**

```csharp
// Chuyển đổi Dictionary lồng nhau thành JSON string
string jsonString = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
```

- `JsonSerializer.Serialize` được sử dụng để chuyển đổi `Dictionary` thành một chuỗi JSON. Tham số `new JsonSerializerOptions { WriteIndented = true }` được sử dụng để làm cho JSON dễ đọc với định dạng có thụt lề.

#### **Chuyển đổi JSON thành Dictionary**

```csharp
// Chuyển đổi JSON string thành Dictionary lồng nhau
var deserializedStudents = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, double>>>(jsonString);
```

- `JsonSerializer.Deserialize` được sử dụng để chuyển đổi chuỗi JSON thành `Dictionary` lồng nhau. Bạn cần chỉ định kiểu dữ liệu mục tiêu để phương thức có thể tạo ra cấu trúc dữ liệu đúng.

### **4. Các Thư Viện và Công Cụ Hỗ Trợ**

#### **`System.Text.Json`**

- **Tài liệu:** [System.Text.Json](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-overview)
- **Cài đặt**: Thư viện này được bao gồm sẵn trong .NET Core 3.0 và .NET 5+.

#### **`Newtonsoft.Json` (Json.NET)**

Nếu bạn sử dụng `Newtonsoft.Json`, bạn có thể thực hiện tương tự như sau:

```csharp
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        var students = new Dictionary<string, Dictionary<string, double>>
        {
            { "Alice", new Dictionary<string, double> { { "Math", 85.5 }, { "English", 90.0 } } },
            { "Bob", new Dictionary<string, double> { { "Math", 78.0 }, { "English", 82.5 } } },
            { "Charlie", new Dictionary<string, double> { { "Math", 92.0 }, { "English", 88.5 } } }
        };

        // Chuyển đổi Dictionary lồng nhau thành JSON string
        string jsonString = JsonConvert.SerializeObject(students, Formatting.Indented);
        Console.WriteLine("Dictionary to JSON:");
        Console.WriteLine(jsonString);

        // Chuyển đổi JSON string thành Dictionary lồng nhau
        var deserializedStudents = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, double>>>(jsonString);
        Console.WriteLine("\nJSON to Dictionary:");
        foreach (var student in deserializedStudents)
        {
            Console.WriteLine($"{student.Key}:");
            foreach (var subject in student.Value)
            {
                Console.WriteLine($"  {subject.Key}: {subject.Value}");
            }
        }
    }
}
```

**Kết quả Console:**

```
Dictionary to JSON:
{
  "Alice": {
    "Math": 85.5,
    "English": 90.0
  },
  "Bob": {
    "Math": 78.0,
    "English": 82.5
  },
  "Charlie": {
    "Math": 92.0,
    "English": 88.5
  }
}

JSON to Dictionary:
Alice:
  Math: 85.5
  English: 90.0
Bob:
  Math: 78.0
  English: 82.5
Charlie:
  Math: 92.0
  English: 88.5
```

**Cài đặt Newtonsoft.Json qua NuGet:**

```bash
dotnet add package Newtonsoft.Json
```

**Tài liệu**: [Newtonsoft.Json Documentation](https://www.newtonsoft.com/json/help/html/Introduction.htm)

### **5. Một số trường hợp khác của Dictionary Lồng Nhau**

#### **Dictionary với Dictionary Lồng Nhau**

```csharp
var nestedDict = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>
{
    {
        "ClassA", new Dictionary<string, Dictionary<string, int>>
        {
            {
                "Semester1", new Dictionary<string, int>
                {
                    { "Alice", 85 },
                    { "Bob", 78 }
                }
            },
            {
                "Semester2", new Dictionary<string, int>
                {
                    { "Alice", 88 },
                    { "Bob", 80 }
                }
            }
        }
    },
    {
        "ClassB", new Dictionary<string, Dictionary<string, int>>
        {
            {
                "Semester1", new Dictionary<string, int>
                {
                    { "Charlie", 92 },
                    { "Dave", 79 }
                }
            }
        }
    }
};
```

**Nội dung JSON tương ứng:**

```json
{
  "ClassA": {
    "Semester1": {
      "Alice": 85,
      "Bob": 78
    },
    "Semester2": {
      "Alice": 88,
      "Bob": 80
    }
  },
  "ClassB": {
    "Semester1": {
      "Charlie": 92,
      "Dave": 79
    }
  }
}
```

