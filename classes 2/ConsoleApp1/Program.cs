public class Person{
    public string Name {get; set;}
    public int Age {get; set;}

    public void Greet(){
        Console.WriteLine("Hello, my name is " + Name);
    }

}

public class Program{
    static void Main(){
        Person person1 = new Person();
        person1.Name = "Matias H";
        person1.Age = 4;
        person1.Greet();
        Person person2 = new Person();
        person2.Name = "Sara W";
        person2.Age = 28;
        person2.Greet();
        Person person3 = new Person();
        person3.Name = "David H";
        person3.Age = 39;
        person3.Greet();

    }
}