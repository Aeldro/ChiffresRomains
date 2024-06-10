namespace ChiffresRomains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                int result = 0;
                List<int> list = new List<int>();

                static bool isOrdered(List<int> listOfNumbers)
                {
                    for (int i = 0; i < listOfNumbers.Count - 1; i++)
                    {
                        if (listOfNumbers[i] < listOfNumbers[i + 1])
                        {
                            return false;
                        }
                    }
                    return true;
                }

                static bool isMoreThanTreeReps(List<int> listOfNumbers)
                {
                    for (int i = 0; i < listOfNumbers.Count; i++)
                    {
                        if (listOfNumbers[i] == 1 || listOfNumbers[i] == 10 || listOfNumbers[i] == 100 || listOfNumbers[i] == 1000)
                        {
                            if (i < listOfNumbers.Count - 3 && listOfNumbers[i] == listOfNumbers[i + 1] && listOfNumbers[i + 1] == listOfNumbers[i + 2] && listOfNumbers[i + 2] == listOfNumbers[i + 3])
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if (i < listOfNumbers.Count - 1 && listOfNumbers[i] == listOfNumbers[i + 1])
                            {
                                return false;
                            }
                        }
                    }
                    return true;
                }

                static bool isMirrored(string romanString)
                {
                    for (int i = 1; i < romanString.Count() - 1; i++)
                    {
                        switch (romanString[i])
                        {
                            case 'V':
                            case 'X':
                                if (romanString[i - 1] == 'I' && romanString[i + 1] == 'I')
                                {
                                    return false;
                                }
                                break;

                            case 'L':
                            case 'C':
                                if (romanString[i - 1] == 'X' && romanString[i + 1] == 'X')
                                {
                                    return false;
                                }
                                break;

                            case 'D':
                            case 'M':
                                if (romanString[i - 1] == 'C' && romanString[i + 1] == 'C')
                                {
                                    return false;
                                }
                                break;
                        }
                    }
                    return true;
                }

                Console.WriteLine("Entrez un chiffre romain.");
                string romanNumber = Console.ReadLine();
                romanNumber = romanNumber.ToUpper();

                for (int i = 0; i < romanNumber.Length; i++)
                {
                    if (romanNumber[i] == 'M')
                    {
                        list.Add(1000);
                    }
                    else if (romanNumber[i] == 'D')
                    {
                        list.Add(500);
                    }
                    else if (romanNumber[i] == 'C')
                    {
                        if (i < romanNumber.Length - 1 && romanNumber[i + 1] == 'D')
                        {
                            list.Add(400);
                            i++;
                        }
                        else if (i < romanNumber.Length - 1 && romanNumber[i + 1] == 'M')
                        {
                            list.Add(900);
                            i++;
                        }
                        else
                        {
                            list.Add(100);
                        }
                    }
                    else if (romanNumber[i] == 'L')
                    {
                        list.Add(50);
                    }
                    else if (romanNumber[i] == 'X')
                    {
                        if (i < romanNumber.Length - 1 && romanNumber[i + 1] == 'L')
                        {
                            list.Add(40);
                            i++;
                        }
                        else if (i < romanNumber.Length - 1 && romanNumber[i + 1] == 'C')
                        {
                            list.Add(90);
                            i++;
                        }
                        else
                        {
                            list.Add(10);
                        }
                    }
                    else if (romanNumber[i] == 'V')
                    {
                        list.Add(5);
                    }
                    else if (romanNumber[i] == 'I')
                    {
                        if (i < romanNumber.Length - 1 && romanNumber[i + 1] == 'V')
                        {
                            list.Add(4);
                            i++;
                        }
                        else if (i < romanNumber.Length - 1 && romanNumber[i + 1] == 'X')
                        {
                            list.Add(9);
                            i++;
                        }
                        else
                        {
                            list.Add(1);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Chiffre romain incorrect.");
                    }
                }

                if (isOrdered(list) && isMoreThanTreeReps(list) && isMirrored(romanNumber))
                {
                    foreach (int item in list)
                    {
                        result += item;
                    }
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Chiffre romain incorrect.");
                }
            }

        }
    }
}
