using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_ChrisCouch
{
    class Program
    {
        static void Main(string[] args)
        {
           char mainMenu;
            mainMenu = GetMainMenu();
            while (mainMenu != '0')
            {
                ProcessMainMenu(mainMenu);
                mainMenu = GetMainMenu();
            }
            Console.WriteLine("Thank You, for your Patronage. GoodBye.");
            Console.ReadLine();
           
            
        }
        static char GetMainMenu()
        {
            char mainMenu;
            DisplayMenu();
            mainMenu = char.ToUpper(char.Parse(Console.ReadLine()));
            while (mainMenu != '1' && mainMenu != '2' && mainMenu != '3' && mainMenu != '4' && mainMenu != '5' && mainMenu != '6' && mainMenu != '7' && mainMenu != '0')
            {
                Console.WriteLine("Error- Invalid Menu Item");
                DisplayMenu();
                mainMenu = char.ToUpper(char.Parse(Console.ReadLine()));
            }
            return mainMenu;
        } 
            static void ProcessMainMenu(char mainMenu) 
        {
            
            switch (mainMenu)
            {
                case '1':
                    NewExpense();
                    break;
                case '2':
                    ViewExpenseReport();
                    break;
                case '3':
                    RemoveExpense();
                    break;
                case '4':
                    EditExpense();
                    break;
                case '5':
                    ImportData();
                    break;
                case '6':
                    ExportData();
                    break;
                case '7':
                    SortTheDataDescendingByDate();
                    break;
            }    
        }
        static void NewExpense()
        {
            Console.WriteLine("My Money Manager - New Expense");
            Console.WriteLine("---------------------------------");
            Console.Write("Index");
            Console.Write("\tDate");
        }
        static void ViewExpenseReport()
        {
            Console.WriteLine("My Money Manager - Expense Report");
            Console.WriteLine("---------------------------------");
            Console.Write("Index");
            Console.Write("\tDate");
        }
        static void RemoveExpense()
        {
            Console.WriteLine("My Money Manager - Remove Expense");
            Console.WriteLine("---------------------------------");
            Console.Write("Index");
            Console.Write("\tDate");
        }
        static void EditExpense()
        {
            Console.WriteLine("My Money Manager - Edit Expense");
            Console.WriteLine("---------------------------------");
            Console.Write("Index");
            Console.Write("\tDate");
        }
        static void ImportData()
        {

        }
        static void ExportData()
        {

        }
        static void SortTheDataDescendingByDate()
        {

        }

        static void DisplayMenu()
        {
            Console.WriteLine("My Money Manager - Main Menu");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1. New Expense");
            Console.WriteLine("2. View Expense Report");
            Console.WriteLine("3. Remove Expense");
            Console.WriteLine("4. Edit Expense");
            Console.WriteLine("5. Import Data");
            Console.WriteLine("6. Export Data");
            Console.WriteLine("7. Sort the data descending by date");
            Console.WriteLine("Enter your choice, 0 to quit");
        }
    }
}
