Console.WriteLine("Enter count of elements in array -> N:");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = GenerateArray(n);
Console.WriteLine("=====Generated array=====");
DisplayArray(array);

Console.WriteLine("=====Resulted array=====");
GenerateNewArray(array);

string[] GenerateArray(int count)
{
    string[] resultArray = new string[count];

    Console.WriteLine("Enter {0} elements of array:", count);
    for (int i = 0; i < count; i++)
    {
        resultArray[i] = Console.ReadLine();
    }

    return resultArray;
}

void GenerateNewArray(string[] array)
{
    string element = "";
    List<string> elementList = new List<string>();
    for (int i = 0; i < array.Length; i++)
    {
        element = array[i];
        if (element.Length <= 3)
        {
            elementList.Add(element);
        }
    }

    string[] newArray = elementList.ToArray<string>();

    DisplayArray(newArray);
}

void DisplayArray(string[] array)
{
    Console.Write("{ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i] + " ");
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine(" }");
}



