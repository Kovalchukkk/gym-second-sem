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

		public void Show_Menu_Gym()
        {
			string input;
			string password;
			do
			{
                Console.WriteLine("Enter a password: ");
				password = Console.ReadLine();

			} while (password != "admin");

			do
			{
				ShowMainMenu();

				input = Console.ReadLine();

				Selection(input);

			} while (input != "0");
		
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
D - To view visitors discounts;
0 - Exit;
";
            Console.WriteLine(menu);
        }

		void Selection(string input)
		{
			switch (input)
			{
				case "1":
					Menu_Visitor_Add();
					break;
				case "2":
					visitorRepository.Show();
					break;
				case "3":
					Menu_Visitor_Delete();
					break;
				case "4":
					Menu_Trainer_Add();
					break;
				case "5":
					trainerRepository.Show();
					break;
				case "6":
					Menu_Trainer_Delete();
					break;
				case "D":
					Menu_Visitor_Show_Discount();
					break;
				default:
					break;
			}
		}

		void Menu_Visitor_Add()
        {
			Visitor temp;
			string name, birthday, country, membership_card;
            Console.WriteLine("Enter a name: ");
			name = Console.ReadLine();
            Console.WriteLine("Enter a birthday(day month): ");
			birthday = Console.ReadLine();
            Console.WriteLine("Enter a country: ");
			country = Console.ReadLine();
            Console.WriteLine("Enter a membership_card(beginner (1 year=500$), average (2 years = 800$), professional(5 years = 2000$)): ");
			membership_card = Console.ReadLine();

			temp = new Visitor(name, birthday, country, membership_card);
			temp.SetMembership_price(membership_card);

            string choice;
			int index = 0, res = 0;
            Console.WriteLine("Do you want to choose a trainer? (yes/no)");
			choice = Console.ReadLine();

			switch (choice)
            {
				case "yes":
					Console.WriteLine("The list of trainers: ");
					trainerRepository.Show();

					res = SafeIndexInput(index);
					
					if (res != -1)
					{
                        try 
						{
							trainerRepository.SetTrainer(temp, res);
							visitorRepository.Add(temp);
                            Console.WriteLine("Trainer was successfully selected!");
                            Console.WriteLine("Visitor added!!!");
						}
						catch (ArgumentOutOfRangeException)
                        {
							Console.WriteLine("We can't find this trainer in the list!");
						}	
					}

					else
					{
						Console.WriteLine("We can't find this trainer in the list!");
					}
					break;
				case "no":
					visitorRepository.Add(temp);
					Console.WriteLine("Visitor added!!!");
					break;
				default:
					break;
			}
        }

		void Menu_Trainer_Add()
        {
			Trainer temp;
			string name;
			int experience;
            Console.WriteLine("Enter a name: ");
			name = Console.ReadLine();
            Console.WriteLine("Enter an experience: ");
			experience = Convert.ToInt32(Console.ReadLine());
			temp = new Trainer(name, experience);
			trainerRepository.Add(temp);
			trainerRepository.SetId();
            Console.WriteLine("Trainer added!!!");
        }
		
		void Menu_Visitor_Delete()
        {
			int del_indx = 0, res = 0;
			res = SafeIndexInput(del_indx);
			
			if (res != -1)
            {
				try
				{
					visitorRepository.Del(res);
					Console.WriteLine("Visitor deleted!!!");
				}

				catch (ArgumentOutOfRangeException)
				{
					Console.WriteLine("We can't find this visitor in the list!");
				}
			}
			
			else
            {
                Console.WriteLine("We can't find this visitor in the list!");
            }
        }

		void Menu_Trainer_Delete()
		{
			int del_indx = 0, res = 0;
			res = SafeIndexInput(del_indx);

			if (res != -1)
			{
				try
				{
					trainerRepository.Del(res);
					Console.WriteLine("Trainer deleted!!!");
				}

				catch (ArgumentOutOfRangeException)
				{
					Console.WriteLine("We can't find this trainer in the list!");
				}
			}

			else
			{
				Console.WriteLine("We can't find this trainer in the list!");
			}
		}

		void Menu_Visitor_Show_Discount()
        {
			int indx_ = 0, res = 0;
			res = SafeIndexInput(indx_);

			if (res != -1)
			{
				try
				{
					visitorRepository.ShowDiscount(res);
				}

				catch (ArgumentOutOfRangeException)
				{
					Console.WriteLine("We can't find this visitor in the list!");
				}
			}

			else
			{
				Console.WriteLine("We can't find this visitor in the list!");
			}
		}

		int SafeIndexInput(int _indx)
        {
			Console.WriteLine("Please enter an index: ");
			try
			{
				_indx = int.Parse(Console.ReadLine());
				return _indx;
			}

			catch (FormatException)
			{
				return -1;
			}
		}
	}
}
