namespace ConsoleApp1.Implementation
{
    public class MamiferoAnimal : Animal
    {
        public MamiferoAnimal(int id, string name) : base(id, name)
        { }

        public override decimal CalculatePeso(decimal peso)
        {
            return (peso);
        }

        public override decimal PesoMinimo()
        {
            return 300;
        }
    }
}