using System.Threading.Tasks;

class Program{
    public async Task DownloadDataAsync(){
        Console.WriteLine("Starting download...");
        await Task.Delay(2500);
        Console.WriteLine("Download completed.");
    }

    public async Task DownloadDataAsync2(){
        Console.WriteLine("Starting download 2...");
        await Task.Delay(3000);
        Console.WriteLine("Download 2 completed.");
    }

    public async Task DownloadDataAsyncWithErrorHandling(){
        try{
            Console.WriteLine("Starting download...");
            Console.WriteLine("Faking error...");
            await Task.Delay(2000);
            Console.WriteLine("Download completed.");
        }
        catch(Exception ex){
            Console.WriteLine("A real error " + ex.Message);
        }
    }

    static async Task Main(){
        Program program = new Program();
        await program.DownloadDataAsync();
        Task task1 = program.DownloadDataAsync();
        Task task2 = program.DownloadDataAsync2();
        await Task.WhenAll(task1,task2);
        Console.WriteLine("All downloads completed.");
        await program.DownloadDataAsyncWithErrorHandling();
    }
}