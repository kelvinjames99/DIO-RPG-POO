using System.Collections.Generic;

namespace DOTNET___POO.src.Entities
{
    public class Wizard : Hero
    {
        public int HealthPoints { get; set; }
        public int MagicPoints { get; set; }
        List<string> MagicBook = new List<string>();
        public Wizard(int HealthPoints, int MagicPoints, string Name, int Level, string Herotype) : base(Name, Level, Herotype)
        {
            this.HealthPoints = HealthPoints;
            this.MagicPoints = MagicPoints;
        }

        public override string Attack()
        {
            return $"{this.Name} atacou com seu cajado";
        }
        public string Attack(string Magic)
        {
            if (MagicBook.Contains(Magic))
            {
                return $"{this.Name} lançou {Magic}";
            }
            return $"{this.Name} não aprendeu essa magia ainda";
        }

        public void LearnMagic(string Magic)
        {
            MagicBook.Add(Magic);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nHP: {this.HealthPoints} -- MP: {this.MagicPoints}\nMagias: {string.Join(", ", this.MagicBook)}";
        }

    }
}