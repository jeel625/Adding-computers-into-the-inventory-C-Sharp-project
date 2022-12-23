
using MainProject;

int option = 0, copyIndex = 0, index = 0, computerCounter = 0, sn = 0;
char choice='N';
bool checkingValue = false;
int passwordCounter = 2;
string brand;
string model;
double price = 0;
string password;

do
{
    try
    {
        Console.Write("Please enter the number of computer that you want to enter :");
        index = Convert.ToInt32(Console.ReadLine());

        if (index < 0)
            Console.WriteLine("Please Enter Valid Value");
    }
    catch (Exception e)
    {
        Console.WriteLine("Please Enter Valid Value");
        index = -1;
    }
} while (index < 0);

Computer[] computer = new Computer[index]; 
copyIndex = index;
do
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("| What do you want to do?                              |");
    Console.WriteLine("| 1. Enter new computers                               |");
    Console.WriteLine("| 2. Change information of a computer                  |");
    Console.WriteLine("| 3. Display all computers by a specific brand         |");
    Console.WriteLine("| 4. Display all computers under a certain a price.    |");
    Console.WriteLine("| 5. Display all computers .                           |");
    Console.WriteLine("| 6. Quit                                              |");
    Console.WriteLine("-------------------------------------------------------");
    do
    {
        try
        {
            Console.Write("Please enter your choice  : ");
            option = Convert.ToInt32(Console.ReadLine());
            if (option < 0)
            {
                Console.WriteLine("choosen option must be positive");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("choosen option must be valid");
            option = -1;
        }
    } while (option < 0);

    switch (option)
    {
        case 1:
            {
                bool flag = true;

                Console.Write("Please Enter password :");
                password = Console.ReadLine();

                while ((Computer.password != password))
                {
                    if (passwordCounter == -1)
                    {
                        flag = false;
                        break;
                    }
                    if (passwordCounter == 0) //passwordcounetr=3
                        Console.WriteLine("It's Last chance to enter password");
                    else
                        Console.WriteLine("You have only " + (passwordCounter) + " chances left");

                    passwordCounter--;//passwordcounter=passoerdcounter-1;

                    Console.Write("Please Enter password :");
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------------------");
                    password = Console.ReadLine();
                }

                if (flag == true)
                {             
                    do
                    {
                        bool checkingIndex = false;
                        
                        if (copyIndex - 1 >= 0)
                        { 
                            Console.WriteLine("You can insert " + (copyIndex) + " computers");
                            Console.WriteLine();
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine(" Enter Computer Brand :");
                            brand = Console.ReadLine();
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine(" Enter Computer Model :");
                            model = Console.ReadLine();
                            Console.WriteLine("----------------------------------------------------------");

                        b1:
                            do
                            {
                                try
                                {
                                    Console.WriteLine(" Enter Serial Number :");
                                    sn = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("----------------------------------------------------------");
                                    if (sn < 0)
                                        Console.WriteLine("Serial Number must be positive");
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Serial Number must be positive");
                                    sn = -1;
                                }
                            } while (sn < 0);

                            for (int i = 0; i < computerCounter; i++)
                            {
                                if (computer[i].getSn() == sn && computer[i].getBrand() == brand)
                                {
                                    Console.WriteLine("This Coemputer is already exist in the inventory");
                                    goto b1;
                                }
                            }

                            do
                            {
                                try
                                {
                                    Console.WriteLine(" Enter Computer Price :");
                                    price = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("----------------------------------------------------------");

                                    if (price < 0)
                                        Console.WriteLine("price must be positive");
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("price must be valid value");
                                    price = -1;
                                }
                            } while (price < 0);
                               
                              
                            computer[computerCounter] = new Computer(brand, model, sn, price);
                            checkingValue = true;
                            computerCounter++;
                            copyIndex--;
                        }
                        else
                        {
                            Console.WriteLine("You cannot insert a Computer because inventory is full...");
                            break;
                        }

                        Console.Write("Do you still want to continue press Y or y :");
                        choice = Convert.ToChar(Console.ReadLine());
                    } while (choice == 'Y' || choice == 'y');
                }
                break;
            }
        case 2:
            {
                bool flag = true;

                Console.Write("Please Enter password :");
                password = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------");
                while ((Computer.password != password))
                {
                    if (passwordCounter == -1)
                    {
                        flag = false;
                        break;
                    }
                    if (passwordCounter == 0)
                        Console.WriteLine("It's Last chance to enter password");
                    else
                        Console.WriteLine("You have only " + (passwordCounter) + " chances left");

                    passwordCounter--;
                    Console.Write("Please Enter password :");
                    password = Console.ReadLine();
                }

                if (flag && checkingValue)
                {
                    int getcomputerCounter = 0, opt = 0;
                    int tempSn = 0, tempPrice = 0;
                    string tempBrand = "", tempModel = "";

                    for (int i = 0; i < computerCounter; i++)
                    {
                        Console.WriteLine("Computer index :" + i);
                    }

                    Console.WriteLine("Please Enter computer index");
                    getcomputerCounter = Convert.ToInt32(Console.ReadLine());

                    if (getcomputerCounter < computerCounter)
                    {
                        computer[getcomputerCounter].showComputer(getcomputerCounter);
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine("----------------------------------------------------------");
                            Console.WriteLine("| which information would like to change?                |");
                            Console.WriteLine("| 1. Brand                                               |");
                            Console.WriteLine("| 2. Model                                               |");
                            Console.WriteLine("| 3. SN                                                  |");
                            Console.WriteLine("| 4. Price                                               |");
                            Console.WriteLine("| 5. Quit                                                |");
                            Console.WriteLine("----------------------------------------------------------");
                            do
                            {
                                try
                                {
                                    opt = Convert.ToInt32(Console.ReadLine());

                                    if (opt < 0)
                                        Console.WriteLine("Entered value must be positive!!");
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Invalid inpit : !! Enter Again : ");
                                    opt = -1;
                                }
                            } while (opt < 0);


                            switch (opt)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Enter new brand :");
                                        tempBrand = Console.ReadLine();
                                        Console.WriteLine();
                                        Console.WriteLine("----------------------------------------------------------");
                                        computer[getcomputerCounter].setBrand(tempBrand);
                                        Console.WriteLine("After Updating");
                                        Console.WriteLine();
                                        Console.WriteLine("----------------------------------------------------------");
                                        computer[getcomputerCounter].showComputer(getcomputerCounter);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Enter new Model :");
                                        tempModel = Console.ReadLine();
                                        Console.WriteLine();
                                        Console.WriteLine("----------------------------------------------------------");
                                        computer[getcomputerCounter].setBrand(tempModel);
                                        Console.WriteLine("After Updating");
                                        Console.WriteLine();
                                        Console.WriteLine("----------------------------------------------------------");
                                        computer[getcomputerCounter].showComputer(getcomputerCounter);
                                        break;
                                    }
                                case 3:
                                    {
                                        do
                                        {
                                            try
                                            {
                                                Console.WriteLine(" Enter Serial Number :");
                                                tempSn = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine();
                                                Console.WriteLine("----------------------------------------------------------");

                                                if (tempSn < 0)
                                                    Console.WriteLine("Serial Number must be positive");
                                            }
                                            catch (Exception e)
                                            {
                                                Console.WriteLine("Serial Number must be valid");
                                                tempSn = -1;
                                            }
                                        } while (tempSn < 0);

                                        computer[getcomputerCounter].setSn(tempSn);
                                        Console.WriteLine("After Updating");
                                        Console.WriteLine();
                                        Console.WriteLine("----------------------------------------------------------");
                                        computer[getcomputerCounter].showComputer(getcomputerCounter);
                                        break;
                                    }
                                case 4:
                                    {
                                        do
                                        {
                                            try
                                            {
                                                Console.WriteLine(" Enter Computer Price :");
                                                tempPrice = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine();
                                                Console.WriteLine("----------------------------------------------------------");

                                                if (tempPrice < 0)
                                                    Console.WriteLine("price must be positive");
                                            }
                                            catch (Exception e)
                                            {
                                                Console.WriteLine("price must be valid value");
                                                tempPrice = -1;
                                            }
                                        } while (tempPrice < 0);

                                        computer[getcomputerCounter].setPrice(tempPrice);
                                        Console.WriteLine("After Updating");
                                        computer[getcomputerCounter].showComputer(getcomputerCounter);
                                        break;
                                    }
                            }

                        } while (opt != 5);
                    }
                    else
                        Console.WriteLine("Entered Computer index should be under "+computerCounter+" !!");

                    
                }
                else
                {
                    Console.WriteLine("First Enter the Value in to the inventory ");
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------------------");
                }
                break;
            }
        case 3:
            {
                if (checkingValue)
                {
                    bool checkingBrand = true;
                    string tempBrand = "";
                    if (checkingValue)
                    {
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine("Please Enter Brand name :");
                        tempBrand = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------------");
                        for (int i = 0; i < computerCounter; i++)
                        {
                            if (computer[i].getBrand().ToLower() == tempBrand.ToLower())
                            {
                                computer[i].showComputer();
                                checkingBrand = false;
                            }

                        }
                        if (checkingBrand)
                            Console.WriteLine("There is no computer in the inventory related to this brand name.");
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("First enter the computer in the inventory");
                }
                    
                
                break;
            }
        case 4:
            {
                if (checkingValue)
                {
                    bool checkingPrice = true;
                    int tempPrice = 0;
                    if (checkingValue)
                    {
                        Console.WriteLine("Please Enter Price :");
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------------");
                        do
                        {
                            try
                            {
                                Console.WriteLine(" Enter Computer Price :");
                                tempPrice = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                Console.WriteLine("----------------------------------------------------------");

                                if (tempPrice < 0)
                                    Console.WriteLine("price must be positive");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("price must be valid value");
                                tempPrice = -1;
                            }
                        } while (tempPrice < 0);

                        for (int i = 0; i < computerCounter; i++)
                        {
                            if (computer[i].getPrice() < tempPrice)
                            {
                                checkingPrice = false;
                                computer[i].showComputer();
                            }
                        }
                        if (checkingPrice)
                            Console.WriteLine("There is no computer under price $" + tempPrice + ".");
                    }
                    else
                    {
                        Console.WriteLine("First Enter the Value in to the inventory ");
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("First add the coimputer in the inventory");
                }
                break;
            }
        case 5:
            {
                int counter = 0;
                if (checkingValue)
                {
                    do
                    {
                        computer[counter].showComputer(counter);
                        counter++;
                    } while (computerCounter != counter);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("First please enter the computer in the inventory");
                }
              
                break;
            }
        case 6:
            {
                string computerList = @"D:\Lasalle_College_Study\Semester-2\C#\MainProject\Mainroject.txt";
                try
                {
                    using (StreamWriter textList = new StreamWriter(computerList))
                    {

                        textList.WriteLine("List of PC(s) in 'Super-Duper Computers' store:\n");

                        for (int i = 0; i < computerCounter; i++)
                        {

                            if (computer[i] != null)
                            {

                                textList.WriteLine("-------------------------------");

                                textList.WriteLine($"{i + 1}. Computer:");

                                textList.WriteLine($"\t\tBrand: {computer[i].getBrand()}");

                                textList.WriteLine($"\t\tModel: {computer[i].getModel()}");

                                textList.WriteLine($"\t\tSN:    {computer[i].getSn()}");

                                textList.WriteLine($"\t\tPrice: ${computer[i].getPrice()}");

                            }
                        }

                    }
                }
                catch (Exception exp)
                {

                    Console.Write(exp.Message);
                }

                    Console.WriteLine("Good bye!");
                     Console.WriteLine("Exiting program...");

                string[] textFile = System.IO.File.ReadAllLines(@"D:\Lasalle_College_Study\Semester-2\C#\MainProject\Mainroject.txt");

                System.Console.WriteLine("\nContents of computerList.txt file:");

                foreach (string line in textFile)
                {

                    Console.WriteLine("\t" + line);

                }

                break;
            }
        default:
            {
                Console.WriteLine("Value must 1 to 5 !!!");

                break;
            }
    }
} while (option != 6);





