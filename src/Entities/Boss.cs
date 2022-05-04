namespace Characters
{
    public class Boss : Character
    {
        public Boss(string CharacterName, int CharacterLevel, string CharacterType) : base(CharacterName, CharacterLevel, CharacterType)
        {
        }

        public override string? Attack()
        {
            return $"{this.CharacterName} attacked with his two swords.";
        }

        public string? SpecialAttack()
        {
            int SpecialAttackUp = 120;
            
            return $"{this.CharacterName} attacked with two swords with {SpecialAttackUp} damage bonus.";
        }
    }
}