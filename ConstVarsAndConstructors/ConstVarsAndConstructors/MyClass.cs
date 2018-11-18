using System;
namespace ConstVarsAndConstructors
{
    public class MyClass
    {
        public string Name { get; set; }
        public int age {get; set;}

        public MyClass(string Name) : this(Name, 100)
        {
            return;
        }

        public MyClass(string name, int age) {
            Name = name;
            age = 25;
        }
    }
}
