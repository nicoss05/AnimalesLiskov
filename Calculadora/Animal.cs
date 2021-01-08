namespace Animales
{
    public abstract class Animal
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Animal(int id, string name)
        {
            this.ID = id; this.Name = name;
        }
        public abstract decimal CalculatePeso(decimal peso);
        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }
    }
    public class MamiferoAnimal : Animal
    {

        public MamiferoAnimal(int id, string name) : base(id, name)
        { }
        public override decimal CalculatePeso(decimal peso)
        {
            return peso;
        }
    }
}