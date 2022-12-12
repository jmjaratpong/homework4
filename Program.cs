using static System.Console;

class Program
{

    static void Main()
    {
        Employee.NewEmployee();
    }    
}

public class Employee
{
    private static Dictionary<string, int> employeeList = new Dictionary<string, int>();

    public static void NewEmployee()
    {
        while (true)
        {
            string name = Input.GetString();
            
            if (employeeList.ContainsKey(name))
            {
                WriteLine();
                WriteLine("________________________________________");
                foreach (KeyValuePair<string, int> employee in employeeList)
                {
                    var emax = employeeList.Values.Max();
                    if (employee.Value == emax)
                    {
                        WriteLine(employee.Key);
                    }
                }
                WriteLine("________________________________________");
                return;
            }
            
            int count = Input.GetInt();

            employeeList.Add(name, count);
        }
    }
}


public static class Input
{
    public static string GetString()
    {
        string s = ReadLine();
        return s;
    }

    public static int GetInt()
    {
        string s = ReadLine();
        if (int.TryParse(s, out int number))
        {
            return number;
        }

        return -1;
    }
}

