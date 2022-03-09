using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym;

namespace Admin
{
    class Menu
    {
        VisitorRepository visitorRepository;
        TrainerRepository trainerRepository;

        public Menu()
        {
            visitorRepository = new VisitorRepository();
            trainerRepository = new TrainerRepository();
        }

        void ShowMainMenu()
        {
            string menu = @"
Gym Sport Life
Choose an operation:
1 - To register a visitor;
2 - To view registered visitors;
3 - To delete a visitor by index;
4 - To register a trainer;
5 - To view registered trainers
6 - To delete a trainer by index;
0 - Exit;
";
            Console.WriteLine(menu);
        }

		void Selection(string input)
		{
			switch (input)
			{
				case "1":
					
					break;
				case "2":
					
					break;
				case "3":
					
					break;
				case "4":
					
					break;
				case "5":
					
					break;
				case "6":
			
					break;
				case "0":
					break;
				default:
                    Console.WriteLine("Error! You chose wrong operation!"); 
					break;
			}
		}

		void Menu_Visitor_Add()
        {
			Visitor temp;
			string choice;
            Console.WriteLine("Do you want to choose a trainer? (yes/no)");

        }

		void Menu_Visitor_Add_With_Trainer(Visitor item)
        {
			  
            Console.WriteLine("Enter a name: ");
        }

	}
}
