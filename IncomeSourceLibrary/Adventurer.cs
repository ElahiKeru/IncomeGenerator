namespace IncomeSourceLibrary
{
    public class Adventurer
    {
        public int Modifier { get; private set; }
        public string Name { get; private set; }

        /// <summary>
        /// public constructor for Guild Member
        /// </summary>
        /// <param name="name">string, character name</param>
        /// <param name="modifier">int, special modifier applied to their rolls</param>
        public Adventurer(string name, int modifier)
        {
            Name = name;
            Modifier = modifier;
        }

        public override string ToString()
        {
            return $"{Name}|{Modifier}";
        }
    }
}
