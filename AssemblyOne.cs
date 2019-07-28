using System;

namespace hometask0_employee
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee salaries as well as general information.
            Printer_assistant P_A = new Printer_assistant();
            P_A.first_and_lastname = "Andrey Kolaur";
            P_A.Age = 38;
            P_A.yers_of_works = 4;
            P_A.salary = 1000;
            P_A.work_award = 200;
            P_A.mobile_phone = 447777766;
            P_A.information_output();

            Printing_press_operator P_P_O = new Printing_press_operator();
            P_P_O.first_and_lastname = "Galushko Alex";
            P_P_O.Agу = 32;
            P_P_O.yers_of_works = 2;
            P_P_O.salary = 1600;
            P_P_O.work_award = 300;
            P_P_O.mobile_phone = 446663399;
            P_P_O.information_output();
        }

        private class Printer_assistant
        {
        }
    }

  
}
