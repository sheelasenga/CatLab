using System;
using System.Web.Script.Serialization;

namespace CatLab
{
    class Program
    {
        static void Main(string[] args)
        {
            integer multiply = new integer();
            CatClass cat = new CatClass();
            
            Method.age5(cat);
            Method.age5(cat);
           Console.WriteLine();
            var json = new JavaScriptSerializer().Serialize(cat);
            Console.WriteLine(json);

            double reverseName;
            double value = multiply.integerMultiply(3, 3, 2);
            Console.WriteLine(value);

            double value2 = multiply.integerSum(3, 3, 2, out reverseName);
            Console.WriteLine(value2);
            Console.ReadLine();
         
         

        }

        class CatClass

    {
        public string name = "Tilly";
        public int age = 2;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
             public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }

      
        }
        public override string ToString()
        {
            return "Name = " + Name + ", Age = " + Age;
        }

    }
        class Method
        {
            public static void age5(CatClass cat1) { cat1.age += 5;}


        }


        
    }
        class integer
        {
            public double integerMultiply(double num1, double num2, double num3)//, out double reversename)
            {
                

            return (num1 * num2 * num3);

            }
            public double integerSum(double num1, double num2, double num3, out double reversename)
            {
            reversename = num1 + num2 + num3;

            return (num1 + num2 + num3);
            }
        
        
        }
        }
    

