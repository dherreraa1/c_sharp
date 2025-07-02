class Program()
{
    public static void Main()
    {
        Cat cat = new Cat();
        Dog dog = new Dog();
        cat.MakeSound();
        cat.Eat();
        dog.MakeSound();
        dog.Eat();

        List<Animal> animals = new List<Animal>();
        animals.Add(new Cat());
        animals.Add(new Dog());

        for(int i = 0; i < animals.Count; i++){
            Console.Write("Animal " + (i + 1) + ". ");
            animals[i].MakeSound();
        }        

    }
}

public interface IAnimal
{
    public void Eat();
}
public class Animal: IAnimal
{
    public virtual void MakeSound(){
        Console.WriteLine("Making sound");
    }

    public void Eat(){
        Console.WriteLine("Eating time");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }

    public void Eat(){
       Console.WriteLine("Dog food"); 
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }

    public void Eat(){
       Console.WriteLine("Cat food"); 
    }
}