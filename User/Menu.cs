using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym;
namespace User
{
    class Menu
    {
		Repository<Visitor> VisitorRepository;
		Repository<Trainer> TrainerRepository;
		Logger logger = new Logger();

		public Menu()
        {
			var factory = FactoryCreator.GetFactory();
			VisitorRepository = factory.GetVisitorRepository();
			TrainerRepository = factory.GetTrainerRepository();
		}

		public void Show_Menu_Gym()
		{
			string input;
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
1 - To view registered visitors;
2 - To view registered trainers
D - To view visitors discounts;
M - To view the most experienced trainer;
P - To view the most popular trainer;
0 - Exit;
";
			Console.WriteLine(menu);
		}

		void Selection(string input)
		{
			switch (input)
			{
				case "1":
					VisitorRepository.Show();
					break;
				case "2":
					TrainerRepository.Show();
					break;
				case "D":
					Menu_Visitor_Show_Discount();
					break;
				case "M":
					try
					{
						TrainerRepository.Show();
						Console.WriteLine("The most experienced trainer is " + TrainerRepository.MaxTrainer());
					}

					catch (Exception)
					{
						logger.Exception("The list of trainers is empty!");
						Console.WriteLine("The list of trainers is empty!");
					}
					break;
				case "P":
					try
					{
						VisitorRepository.Show();
						VisitorRepository.ShowTheMostPopularTrainer();
					}

					catch (FormatException)
					{
						logger.Exception("The list of trainers is empty!");
						Console.WriteLine("The list of trainers is empty!");
					}
					break;
				default:
					break;
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
					VisitorRepository.ShowDiscount(res);
				}

				catch (ArgumentOutOfRangeException)
				{
					logger.Exception("We can't find this visitor in the list!");
					Console.WriteLine("We can't find this visitor in the list!");
				}
			}

			else
			{
				Console.WriteLine("We can't find this visitor in the list!");
			}
		}

		private int SafeIndexInput(int _indx)
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
