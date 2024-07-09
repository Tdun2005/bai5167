using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai báo và khởi tạo dictionary với key và value đều là kiểu string
            var dict1 = new Dictionary<string, string>
            {
                {"Nam", "1A"},
                {"Lan", "2B"},
                {"Mai", "3C"}
            };

            // Duyệt qua các khóa (keys) của dictionary và in chúng ra
            foreach (var item in dict1)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
