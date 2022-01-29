namespace DOTNET___POO.src.Entities
{
    public class Knight : Hero
    {
        public int HealthPoints { get; set; }
        public int MagicPoints { get; set; }
        public Knight(int HealthPoints, int MagicPoints, string Name, int Level, string Herotype) : base(Name, Level, Herotype)
        {
            this.HealthPoints = HealthPoints;
            this.MagicPoints = MagicPoints;
        }

        public string Attack(int hits)
        {
            return $"{this.Name} desferiu {hits} hits com sua espada";
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nHP: {this.HealthPoints} -- MP: {this.MagicPoints} ";
        }

    }
}