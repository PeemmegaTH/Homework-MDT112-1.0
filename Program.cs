using System;

namespace Homework {
    class Password_Homework {
        static void Main(string[] args){
            Console.Write("Enter the password 6 digit :");
            int password = int.Parse(Console.ReadLine());

            if (password >= 1000000 || password < 0) {
                Console.Write("Error");
                return;
            }

            Console.Write("Enter the code name:");
            string code_Name = Console.ReadLine();
          
            bool surcess = false;


            if (code_Name == "FBI" || code_Name == "CIA" || code_Name == "NSA") {
                int unit = (password % 10);
                int tens = (password % 100)/10;
                int hundreds = (password % 1000)/100;
                int thousands = (password % 10000)/1000;
                int tens_of_thousands = (password % 100000)/10000;
                int hundreds_of_thousands = (password % 1000000)/100000;


                /*[[
                -----------------------------------------------------------------------
                Console.WriteLine("hundreds_of_thousands: "+hundreds_of_thousands);
                Console.WriteLine("tens_of_thousands: "+tens_of_thousands);
                Console.WriteLine("thousands: "+thousands);
                Console.WriteLine("hundreds: "+hundreds);
                Console.WriteLine("tens: "+tens);
                Console.WriteLine("unit: "+unit);
                -----------------------------------------------------------------------
                ]]*/


                switch (code_Name){
                case ("CIA"):
                bool cia_condition1 = unit % 3 == 0;
                bool cia_condition2 = (tens != 1 && tens != 3 && tens != 5);
                bool cia_condition3 = (thousands >= 6 && thousands < 8);
                if (cia_condition1 && cia_condition2 && cia_condition3){
                    surcess = true;
                }
                break;
                case ("FBI"):
                bool fbi_condition1 = hundreds_of_thousands >= 4 && hundreds_of_thousands <= 7;
                bool fbi_condition2 = (hundreds % 2 == 0 && hundreds != 6);
                bool fbi_condition3 = (tens_of_thousands % 2 != 0);
                if (fbi_condition1 && fbi_condition2 && fbi_condition3){
                    surcess = true;
                }
                break;
                case ("NSA"):
                bool nsa_condition1 = (30 % unit == 0) ;
                bool nsa_condition2 = (hundreds % 3 == 0 && hundreds % 2 != 0);
                bool nsa_condition3 = (hundreds_of_thousands == 7 || tens_of_thousands == 7
                || thousands == 7 || hundreds == 7 || tens == 7 || unit == 7);

                if (nsa_condition1 && nsa_condition2 && nsa_condition3){
                    surcess = true;
                }
                break;

                }
                
            } else {
                Console.WriteLine("Wrong password!?");
                return;
            }

            Console.WriteLine("Output: " + surcess);

        }
    }
}