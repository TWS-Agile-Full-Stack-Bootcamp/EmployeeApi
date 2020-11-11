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

        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   id == employee.id &&
                   name == employee.name &&
                   age == employee.age &&
                   gender == employee.gender;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, name, age, gender);
        }
    }
}
