class Program{

    public static async Task PerformLongOperationAsync(){
        Console.WriteLine("Starting operation...");
        await Task.Delay(2500);
        Console.WriteLine("Mmm Ok, an error...");
        Console.WriteLine("Operation completed.");
    }

    public static async Task PerformLongOperationAsyncWithErrorHand(){
        try{
            Console.WriteLine("Starting operation...");
            await Task.Delay(2500);
            throw new InvalidOperationException("Simulated long operation error.");
            Console.WriteLine("Operation completed.");
        }
        catch(Exception ex){
            Console.WriteLine("An error happened: " + ex.Message);
        }
    }

    static void Main(){
        Task.Run(async () => await PerformLongOperationAsync()).Wait();
        Console.WriteLine("First method completed.");
        Task.Run(async () => await PerformLongOperationAsyncWithErrorHand()).Wait();
        Console.WriteLine("Second method completed.");
    }

}