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
            return $"{this.CharacterName} attacked magic with bonus {up}.";
        }
    }
}