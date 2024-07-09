using System;
using System.Collections.Generic;

namespace DictClassKey
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Ghi đè Equals và GetHashCode để đảm bảo các khóa là duy nhất
        public override bool Equals(object obj)
        {
            if (obj is Person)
            {
                Person other = obj as Person;
                return this.FirstName == other.FirstName && this.LastName == other.LastName;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (FirstName + LastName).GetHashCode();
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo một Dictionary với kiểu khóa là Person và giá trị là string
            var peopleDictionary = new Dictionary<Person, string>();

            // Thêm một số phần tử vào Dictionary
            peopleDictionary.Add(new Person("Nguyễn", "Văn Nam"), "Nguyễn Văn Nam");
            peopleDictionary.Add(new Person("Trần", "Thị Lan"), "Trần Thị Lan");
            peopleDictionary.Add(new Person("Lê", "Dũng"), "Lê Dũng");

            // Duyệt qua Dictionary sử dụng vòng lặp foreach
            foreach (var entry in peopleDictionary)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
