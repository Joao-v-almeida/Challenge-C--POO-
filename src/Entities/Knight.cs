namespace Characters
{
    public class Knight : Character
    {
        public Knight(string CharacterName, int CharacterLevel, string CharacterType) : base(CharacterName, CharacterLevel, CharacterType)
        {
        }

        public override string? Attack()
        {
            return $"{this.CharacterName} attacked with the sword.";
        }
    }
}