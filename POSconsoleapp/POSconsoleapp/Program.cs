using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSconsoleapp
{
    public static List<Item> Items;
    public static List<Cart> Carts;
    public static List<Checkout> Checkout;

    public void main()
    {
        // Exit program flagging.
        var hasInputExit = false;
        string validDateFormat = "yyyyMMdd HHmmss";

        // Loop to ask the user's input until the user input the "exit" word.
        while (hasInputExit == false)
        {
            var input = string.Empty;
            // Clear the current output on the console.
            Console.Clear();

            // WriteLine will automatically append an enter space,
            // while Write will not automatically append an enter space.
            Console.WriteLine("Welcome!");
            Console.WriteLine("1. Manage Products");
            Console.WriteLine("2. Purchase Products");
            Console.WriteLine("3. View Transactions");
            Console.WriteLine("4. Exit");

            Console.WriteLine("Please choose menu: ");
            // This will read your input until you input an enter space.
            input = Console.ReadLine();

            // If TryParse return true value, it means the input string is a
            // valid number string, you can use the parsedInput variable to consume the value.
            // If false, then it is not a valid number string.
            if (int.TryParse(input, out int parsedInput))
            {
                Console.WriteLine($"Your input is a valid number: {parsedInput}");

                switch (parsedInput)
                {
                    case 1:
                        /* Console.WriteLine("1. Add New Product");
                        Console.WriteLine("2. Update Stock");
                        Console.WriteLine("3. Delete Product");
                        Console.WriteLine("4. Back");

                        var inputString = Console.ReadLine();

                        Console.WriteLine($"Your string: {inputString}");
                        Console.WriteLine("Please enter any key to continue...");
                        Console.ReadLine(); */
                        HandleInputManage();
                        break;
                    case 2:
                        HandleInputNumber();
                        break;
                    case 3:
                        HandleInputDate();
                        break;
                    case 4:
                        hasInputExit = true;
                        break;
                    // Handle the default or when input is not 1, 2, 3, or 4.
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Handle input "1. Manage Products"
        ///</summary>
        void HandleInputManage()
        {
            Console.WriteLine("1. Add New Product");
            Console.WriteLine("2. Update Stock");
            Console.WriteLine("3. Delete Product");
            Console.WriteLine("4. Back");

            var isValidManage = false;

            while (isValidManage = false)
            {
                var inputManage = Console.ReadLine();
                isValidManage = int.TryParse(inputManage, out int parsedInputManage);

                if (isValidManage)
                {
                    Console.WriteLine($"Your input is valid {parsedInputManage}");

                    switch (parsedInputManage)
                    {
                        case 1:
                    }
                }

            }

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        /// <summary>
        /// Handle the "2. Input Number" menu.
        /// </summary>
        void HandleInputNumber()
        {
            Console.WriteLine("Please input your number:");

            var isValidNumber = false;

            while (isValidNumber == false)
            {
                var inputNumber = Console.ReadLine();
                isValidNumber = int.TryParse(inputNumber, out int parsedInputNumber);

                if (isValidNumber)
                {
                    Console.WriteLine($"Your number: {parsedInputNumber}");
                }
                else
                {
                    Console.WriteLine("Invalid number, please try again");
                }
            }

            Console.WriteLine("Please enter any key to continue...");
            Console.ReadLine();
        }

        /// <summary>
        /// Handle the "3. Input Date" menu.
        /// </summary>
        void HandleInputDate()
        {
            Console.WriteLine("Please input your date as string in yyyyMMdd HHmmss format:");

            var isValidDate = false;

            while (isValidDate == false)
            {
                var inputDate = Console.ReadLine();

                // To validate an input string to specific date format, use TryParseExact.
                // Use InvariantCulture to not specify any culture format (such as locale).
                // Use None for the DateTimeStyles to bypass any formatting.
                isValidDate = DateTime.TryParseExact(inputDate, validDateFormat,
                    CultureInfo.InvariantCulture, DateTimeStyles.None,
                    out DateTime parsedInputDate);

                if (isValidDate)
                {
                    Console.WriteLine($"Your date: {parsedInputDate}");
                    Console.WriteLine($"UTC date: {parsedInputDate.ToUniversalTime()}");

                    Console.WriteLine($"Date: {parsedInputDate.Day}");
                    Console.WriteLine($"Month: {parsedInputDate.Month}");
                    Console.WriteLine($"Year: {parsedInputDate.Year}");
                    Console.WriteLine($"Hour: {parsedInputDate.Hour}");
                    Console.WriteLine($"Minute: {parsedInputDate.Minute}");
                    Console.WriteLine($"Second: {parsedInputDate.Second}");

                    var additionalDate = 31;
                    var newDate = parsedInputDate.AddDays(additionalDate);
                    Console.WriteLine($"Your new date + {additionalDate} days: {newDate.ToString("yyyy-MM-dd HH:mm:ss")}");
                }
                else
                {
                    Console.WriteLine("Invalid date, please try again");
                }
            }

            Console.WriteLine("Please enter any key to continue...");
            Console.ReadLine();
        }
    }
}