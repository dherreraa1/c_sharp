using System;

class ToDoList{

    static string[] tasks = new string[10];
    static bool[] isCompleted = new bool[10];
    static int taskCount = 0;

    static void AddTask(){
        if(taskCount < tasks.Length){
            Console.Write("Indicate the task to add: ");
            tasks[taskCount] = Console.ReadLine();
            taskCount++;
            Console.WriteLine("Task " + taskCount + " of " + tasks.Length);
        } else {
            Console.WriteLine("Cannot add more tasks!");
        }
    }

    static void ViewTasks(){
        if(taskCount == 0){
            Console.WriteLine("No tasks added.");
        }
        else {
            Console.WriteLine("List of tasks:");
            for(int i = 0; i < taskCount; i++){
                string status;
                if(isCompleted[i]){
                    status = "Completed";
                } else 
                {
                    status = "Pending";
                }
                Console.WriteLine((i+1) + ". " + tasks[i] + ", " + status);
            }
        }
    }

    static void CompleteTask(){
        if(taskCount == 0){
            Console.WriteLine("No tasks added.");
        }
        else {
            Console.Write("Complete task, enter the corresponding number: ");
            if(int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= taskCount){
                isCompleted[taskNumber-1] = true;
                Console.WriteLine($"Task: {tasks[taskNumber-1]}, completed.");
            }else{
                Console.WriteLine("Invalid task number.");
            }
        }
    }
    
    static void Main(){
        while (true)
        {
            Console.WriteLine(@"Task List
            1. Add task.
            2. View tasks.
            3. Complete task.
            4. Exit.
            What would you like to do? (choose 1-4)");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    CompleteTask();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using this software.");
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }

    }
}