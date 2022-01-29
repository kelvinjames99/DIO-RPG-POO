using System.Collections.Generic;

namespace DOTNET___POO.src.Entities
{
    public class Ninja : Hero
    {
        public int HealthPoints { get; set; }
        public int MagicPoints { get; set; }
        List<string> ItemsBag = new List<string>();
        public Ninja(int HealthPoints, int MagicPoints, string Name, int Level, string Herotype) : base(Name, Level, Herotype)
        {
            this.HealthPoints = HealthPoints;
            this.MagicPoints = MagicPoints;
        }

        public override string Attack()
        {
            return $"{this.Name} atacou com sua katana";
        }

        public string Attack(string Item)
        {
            if (ItemsBag.Remove(Item))
            {
                return $"{this.Name} jogou {Item} no inimigo";
            }
            return $"{this.Name} não possui esse item no inventário";
        }

        public void AddItem(string Magic)
        {
            ItemsBag.Add(Magic);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nHP: {this.HealthPoints} -- MP: {this.MagicPoints}\nItens: {string.Join(", ", this.ItemsBag)}";
        }

    }
}