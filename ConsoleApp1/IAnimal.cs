namespace ConsoleApp1
{
    public interface IAnimal
    {
        int ID { get; set; }
        string Name { get; set; }
        decimal PesoMinimo();
    }
}