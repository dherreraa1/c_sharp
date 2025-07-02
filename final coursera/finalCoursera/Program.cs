using System;
public class Program {
    static int MainMenu(){
        Console.WriteLine(@"Elija una opción:
        1. Agregar tareas nuevas.
        2. Marcar tarea completada.
        3. Mostrar tareas y status.
        4. Terminar programa.");
        return int.Parse(Console.ReadLine());;
    }
    static void EmptyList(){
        Console.WriteLine("No hay tareas agregadas.");
    }
    static void NonValidTask(){
        Console.WriteLine("Tarea no válida");
    }
    static int FindSpot(string[] taskList){
        int spot = 0;
        while(spot < taskList.Length){
            if(taskList[spot] == null){
                return spot;
            }
            spot++;
        }
        return spot;
    }

    static void PrintTask(string[] taskList, bool[] isCompleted){
        string status;
        int index;
        for(int i=0; i < taskList.Length; i++){
            if(taskList[i] == null){
                break;
            }
            if(isCompleted[i]){
                status = "Completada.";
            }else{
                status = "Pendiente.";
            }
            index = i + 1;
            Console.WriteLine(index + ". " + taskList[i] + ": " + status);
        }
    }
   public static void Main() {
        string[] taskList = new String[3];
        bool[] isCompleted = new bool[3];
        string newTask;
        int option;
        bool runProgram = true;

        while(runProgram){
            option = MainMenu();
            switch(option){
                case 1:
                    if(FindSpot(taskList) < taskList.Length){
                        Console.WriteLine("Ingrese la tarea que desea agregar: ");
                        newTask = Console.ReadLine();
                        taskList[FindSpot(taskList)] = newTask;
                        Console.WriteLine("Tarea agregada: " + newTask);
                    } else{
                    Console.WriteLine("No se pueden agregar nuevas tareas.");
                    }
                    break;
                case 2:
                    if(FindSpot(taskList) == 0){
                        EmptyList();
                    } else{
                        Console.WriteLine("Indique la tarea a completar (1,2 o 3): ");
                        int update = int.Parse(Console.ReadLine()) - 1;
                        if(update < 0 || update >= taskList.Length ){
                            NonValidTask();
                        }else if(taskList[update] == null){
                            NonValidTask();
                        }else if(!isCompleted[update]){
                            Console.WriteLine("Desea actualizar la tarea " + taskList[update] + "? (s)");
                            string confirmation = Console.ReadLine();
                            if (confirmation.ToLower() == "s"){
                                isCompleted[update] = true;
                                Console.WriteLine("Tarea actualizada!");
                            } 
                        }else{
                            Console.WriteLine("Tarea ya completada.");
                        }
                    }
                    break;
                case 3:
                    if(FindSpot(taskList) == 0){
                        EmptyList();
                    } else{
                        PrintTask(taskList, isCompleted);
                    }
                    break;
                case 4:
                    runProgram = false;
                    Console.WriteLine("Bye!");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
   }
}