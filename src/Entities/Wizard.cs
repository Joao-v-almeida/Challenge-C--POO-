namespace Characters
{
    public class Wizard : Character
    {
        public Wizard(string CharacterName, int CharacterLevel, string CharacterType) : base(CharacterName, CharacterLevel, CharacterType)
        {
        }

        public override string? Attack()
        {
            return $"{this.CharacterName} attacked with magic.";
        }

        public string? Attack(int up)
        {
            if (up > 5 )
                return $"{this.CharacterName} attacked magic with {up} strong bonus.";
            else
                return $"{this.CharacterName} attacked magic with {up} strong weak.";
        }
    }
}