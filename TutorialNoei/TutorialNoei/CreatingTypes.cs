using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialNoei
{
    public class CreatingTypes
    {

    }

    public abstract partial class YourClassName<T> where T : class
    { 
    
    }

    [Obsolete("This class has no method.")]
    public sealed partial class YourSealedClass : YourClassName<CreatingTypes>
    {
        // Field 
        // Method
        // Constructor
        // Deconstructor
        // Property
        // Operator
        // NestedType
    }

    public class Fields
    {
        public Fields(int number)
        {
            this.number = number;
        }

        string Name;
        public int Age = 10, BirthDay = 1995;
        static int NumberOfSubscriberCardDigits = 14;
        internal string ClassFriendlyName = "مشدی";

        protected readonly int number = 50; // Runs before constructor.

        public static readonly string TempFolder = System.IO.Path.GetTempPath();
        public const string TEMP_FOLDER = "C:\\temp"; // Replace
    }

    public class ModuleA
    {
        public ModuleA()
        {
            // Versioning Issue.
            var compileTimeEvaluatedTemplFolder = Fields.TEMP_FOLDER;
            var runtimeEvaluatedTempFolder = Fields.TempFolder;
        }
    }


    public class LocalMethod
    {
        public LocalMethod()
        {
            int calculateAge(DateTime birthDate) => (DateTime.Now.Year - birthDate.Year);

            int nonExpressionBodiedCalculateAge(DateTime birthDate)
            {
                return DateTime.Now.Year - birthDate.Year;
            }

            calculateAge(new DateTime(1995, 1, 10));

            int initialGoods = 500;
            int remainingGoods = 100;

            int calculateProfit() // Static nonono no
            {
                return (initialGoods - remainingGoods) * 100;
            }
        }
    }

    public class MethodOverloading
    {
        public MethodOverloading()
        {
            int a;
            //FooLivingWithSameSig(ref a);

            //Goo(10, 20, 30, 26);

            Goo(new int[] { 10, 20, 30 });
        }

        public void Foo(double x) { }
        public void Foo(int x, float y) { }
        public void Foo(float x, int y) { }

        float Foo(int x) { return x; }
        //int Foo(int x) { return x; } // Compile-time error

        void FooLivingWithSameSig(out int x) 
        {
            x = 50;
        }
        void FooLivingWithSameSig(int x) { }

        void FooCoexistRefOut(ref int x) { }
        //void FooCoexistRefOut(out int x) { }
        
        void Goo(int[] x) { }
        //void Goo(params int[] x) { } // Compile-time error
    }

    public class SubConstructors : Constructors
    {
        public SubConstructors() : base()
        {
            
        }
    }

    public class Constructors
    {
        public DateTime BirthDay;
        public string FirstName;
        public string LastName;
        private string Email;
        // Automatic Constructor

        // Expression BodiedConstructor
        public Constructors(DateTime birthDay) => BirthDay = birthDay;

        public Constructors(string firstName) : this(birthDay: new DateTime(1996,1,10))
        {
            FirstName = firstName;
        }

        // Constructor Overloading
        public Constructors(string firstName, string lastName) : this(firstName)
        {
            LastName = lastName;
        }

        // Protected Constructor
        private Constructors(string firstName, string lastName, string email) : this(firstName, lastName)
        {
            Email = email;
        }

        internal Constructors()
        {
            
        }

        protected static Constructors _constructors;
        public static Constructors Instance => _constructors = _constructors ?? new Constructors();        

        public void Deconstruct(out string firstName, out string lastName, out int age)
        {
            firstName = FirstName;
            lastName = LastName;
            age = DateTime.Now.Year - BirthDay.Year;
        }
    }

    public class Rectangle
    {
        public float Width;
        public float Height;

        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;        
        }

        //public Rectangle(float width, float height) => (Width, Height) = (width, height);
    }


    public class ConstructorTest
    {
        public ConstructorTest()
        {
            Constructors a = new Constructors(firstName: "Reza", lastName: "Noei");
            
            (string firstName, string lastName, int age) = a;           

            // Note parameterless constructors can omit empty parentheses
            Bunny b1 = new Bunny
            {
                Name = "Bo",
                LikesCarrots = true,
                LikesHumans = false
            };

            Bunny b2 = new Bunny("Bo")
            {
                LikesCarrots = true,
                LikesHumans = false
            };

            Bunny temp2 = new Bunny("Bo");
            temp2.LikesCarrots = true;
            temp2.LikesHumans = false;
            Bunny b2 = temp2;

            Bunny temp1 = new Bunny(); // temp1 is a compiler-generated name
            temp1.Name = "Bo";
            temp1.LikesCarrots = true;
            temp1.LikesHumans = false;
            Bunny b1 = temp1;
        }
    }

    public class Bunny
    {
        public string Name { get; }
        public bool LikesCarrots { get; } 
        public bool LikesHumans { get; }
        public Bunny() 
        {
            Name = "Reza";
        }

        public Bunny(string n) => Name = n;
    }
}
