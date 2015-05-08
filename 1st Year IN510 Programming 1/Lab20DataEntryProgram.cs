using System;

namespace Lab20DataEntryProgram
{
    public struct ClassMembers
    {
        public string firstname;
        public string lastname;
        public string address;
    }

    class Lab20DataEntryProgram
    {
        static void Main()
        {
            ClassMembers[] students = new ClassMembers[5];
            int count = 0;

            Console.WriteLine("Please Enter The Name Of The Student Or Enter To End:");
            string tempname = Console.ReadLine();

            while (tempname != "" && count < 5)
            {
                students[count].firstname = tempname;
                Console.WriteLine("Thank You, Now Enter Last Name:");
                students[count].lastname = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Thank You, Now Enter Address:");
                students[count].address = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Thank You This Student Has Been Stored:");
                Console.WriteLine();

                Console.WriteLine("{0} {1} from {2}", students[count].firstname, students[count].lastname, students[count].address);
                count = count + 1;
                Console.WriteLine();

                Console.WriteLine("Please Enter The Next Name (Up To Five Students) Or Press Enter To End Entries:");
                tempname = Console.ReadLine();
            }

            count = 0;
            Console.WriteLine("Thank You, Please Press v To View the students Details Stored Or Enter To End");
            string tempname2 = Console.ReadLine();

            while (tempname2 != "" && count < 5)
            {
                Console.WriteLine();
                Console.WriteLine("{0} {1} from {2}", students[count].firstname, students[count].lastname, students[count].address);
                count = count + 1;
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
