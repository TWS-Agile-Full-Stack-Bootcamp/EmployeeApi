using System;
namespace EmployeeApi.Models
{
    public class Employee
    {
        private readonly int id;
        private readonly string name;
        private readonly int age;
        private readonly string gender;

        public Employee(int id, string name, int age, string gender)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public int Id { get => id; }
        public string Name { get => name; }
        public int Age { get => age; }
        public string Gender { get => gender; }
    }
}
