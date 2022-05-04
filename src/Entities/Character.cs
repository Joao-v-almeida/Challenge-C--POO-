namespace Characters
{
    public abstract class Character
    {
        public Character(string CharacterName, int CharacterLevel, string CharacterType)
        {
            this.CharacterName = CharacterName;
            this.CharacterLevel = CharacterLevel;
            this.CharacterType = CharacterType;
        }

        public string? CharacterName { get; set; }
        public int CharacterLevel { get; set; }
        public string? CharacterType { get; set; }

        public override string? ToString()
        {
            return $@"hero characteristics: 
            Name: {this.CharacterName}
            Level: {this.CharacterLevel}
            Type: {this.CharacterType}
            ";
        }

        public virtual string? Attack()
        {
            return $"{this.CharacterName} attacked.";
        }
    }
}