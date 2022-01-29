namespace DOTNET___POO.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public Hero(string Name, int Level, string Herotype)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = Herotype;
        }

        public virtual string Attack()
        {
            return $"{this.Name} atacou com sua espada";
        }

        public override string ToString()
        {
            return $"{this.Name} {this.HeroType} lvl {this.Level}";
        }
    }
}