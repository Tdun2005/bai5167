// 51a
using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo một dictionary với kiểu key là string và value là int
            var myDictionary = new Dictionary<string, int>
            {
                {"apple", 1},
                {"banana", 2},
                {"cherry", 3}
            };

            // Duyệt qua dictionary
            Console.WriteLine("Duyệt qua dictionary:");
            foreach (var kvp in myDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Duyệt qua Keys
            Console.WriteLine("\nDuyệt qua Keys:");
            foreach (var key in myDictionary.Keys)
            {
                Console.WriteLine($"Key: {key}");
            }

            // Duyệt qua Values
            Console.WriteLine("\nDuyệt qua Values:");
            foreach (var value in myDictionary.Values)
            {
                Console.WriteLine($"Value: {value}");
            }

            // Ví dụ về khai báo biến tự định kiểu
            var i = 1;
            var message = "Hello, World!";
            var pi = 3.14;
            var isCompleted = true;

            Console.WriteLine("\nCác biến tự định kiểu:");
            Console.WriteLine($"i: {i}, message: {message}, pi: {pi}, isCompleted: {isCompleted}");
        }
    }
}
// 51b
using System;
using System.Collections.Generic;

namespace Dict1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai báo và khởi tạo dictionary
            var dict1 = new Dictionary<int, string>
            {
                {3, "Nam"},
                {8, "Lan"}
            };

            // Duyệt qua dictionary và in các key-value
            foreach (var item in dict1)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
// 51c
using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai báo và khởi tạo dictionary
            var dict1 = new Dictionary<int, string>
            {
                {3, "Nam"},
                {8, "Lan"}
            };

            // Duyệt qua dictionary và in các key-value
            foreach (var item in dict1)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
// 51d
using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai báo và khởi tạo dictionary
            var dict1 = new Dictionary<int, string>
            {
                {3, "Nam"},
                {8, "Lan"}
            };

            // Thêm phần tử vào dictionary sử dụng phương thức Add
            dict1.Add(7, "Mai");

            // Duyệt qua dictionary và in các key-value
            foreach (var item in dict1)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
// 51e
using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai báo và khởi tạo dictionary
            var dict1 = new Dictionary<int, string>
            {
                {3, "Nam"},
                {8, "Lan"},
                {7, "Mai"}
            };

            // Duyệt qua các khóa (keys) của dictionary và in chúng ra
            foreach (var key in dict1.Keys)
            {
                Console.WriteLine(key.ToString());
            }
        }
    }
}
// 51g
using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai báo và khởi tạo dictionary
            var dict1 = new Dictionary<int, string>
            {
                {3, "Nam"},
                {8, "Lan"},
                {7, "Mai"}
            };

            // Duyệt qua các giá trị (values) của dictionary và in chúng ra
            foreach (var val in dict1.Values)
            {
                Console.WriteLine(val);
            }
        }
    }
}
