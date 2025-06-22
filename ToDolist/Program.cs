Console.WriteLine("To Do list Project");

Console.WriteLine("MENU");

Console.WriteLine("1. View Tasks");
Console.WriteLine("2. Add Tasks");
Console.WriteLine("3. Delete Tasks");
Console.WriteLine("4. Exit the menu");

List<string> tasks = new List<string>();
int taskCount;
while (true)
{
    

    Console.WriteLine("Please choose a number between 1 and 4");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":

            Console.WriteLine("Tasks: ");
            foreach (string i in tasks)
            {
                Console.WriteLine(i);
            }

            break;
    
        case "2":
            Console.WriteLine("Add Task: ");
            string newTask = Console.ReadLine();
            tasks.Add(newTask);
            break;
        case "3":
            Console.WriteLine("Delete Task: ");
            Console.WriteLine("Enter task index '0 to 9' ");
            string result = Console.ReadLine();
            bool isInteger = int.TryParse(result, out taskCount);
            tasks.RemoveAt(taskCount);
            break;
        default:
            Console.WriteLine("Exiting...");
            Console.WriteLine("Bye!!!");
            Environment.Exit(0);
            break;
    }

}
