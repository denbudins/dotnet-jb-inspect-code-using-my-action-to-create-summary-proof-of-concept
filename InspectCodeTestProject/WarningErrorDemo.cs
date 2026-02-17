using System;

namespace InspectCodeTestProject
{
    // Violates naming conventions, unused field, redundant parentheses, unnecessary usings, and more
    class test_class // should be PascalCase, missing access modifier
    {
        int unusedField = 0; // unused field
        public string name; // should be PascalCase
        private int _Value; // should be camelCase
        public int BadProperty { get; set; } // property name is fine, but let's add more issues
        public int bad_property { get; set; } // should be PascalCase

        public test_class(string name)
        {
            this.name = name;
            if ((true)) // redundant parentheses
            {
                Console.WriteLine("Redundant parentheses and always true");
            }
        }

        public void DoStuff()
        {
            var x = 5;
            if (x == 5)
            {
                Console.WriteLine("x is five");
            }
            else
            {
                Console.WriteLine("x is not five");
            }
        }

        public void unusedMethod() // should be PascalCase, unused
        {
            int y = 0;
        }
    }

    // Interface not starting with I
    public interface NotIInterface
    {
        void DoWork();
    }

    // Class not matching file/folder structure
    public class anotherClass
    {
        public void DoNothing() { }
    }
}
