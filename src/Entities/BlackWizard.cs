namespace Characters
{
    public class BlackWizard : Character
    {
        public BlackWizard(string CharacterName, int CharacterLevel, string CharacterType) : base(CharacterName, CharacterLevel, CharacterType)
        {
        }

        public override string? Attack()
        {
            return $"{this.CharacterName} attacked with black magic.";
        }

        public string? Attack(int up)
        {
            if (up > 10 )
                return $"{this.CharacterName} attacked black magic with {up} strong bonus.";
            else
                return $"{this.CharacterName} attacked black magic with {up} strong weak.";
        }
    }
}