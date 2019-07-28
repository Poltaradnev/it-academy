using System;

namespace hometask0_employee
{
    public class Employee
    {                
        public string first_and_lastname;
        public int Age;
        public int mobile_phone ;
        private protected static int salary ;
        private protected static int work_award ;
        private protected static int yers_of_works;


        public void information_output()
        {
            Console.WriteLine($"FirstName and LastName: {first_and_lastname}  Age {Age}  Mobile phone{mobile_phone}");
        }
        private protected static void MethodPrivetProtected()

        {
            Console.WriteLine($"Salary:{salary}  Work award {work_award} Yers of works {yers_of_works}");
        }
    }
}
