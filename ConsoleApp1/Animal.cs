namespace ConsoleApp1
{
    public abstract class Animal : IAnimal, IAnimalPeso
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Animal(int id, string name)
        {
            this.ID = id;
            this.Name = name;

        }

        public abstract decimal CalculatePeso(decimal peso);

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }

        public abstract decimal PesoMinimo();
    }
}

