namespace RoleplayGame
{
    public interface ICharacter
    {
        string Name { get; set; }

        int AttackValue{ get; }

        int DefenseValue{ get; }

        int Health{ get; }

        void RecieveAttack(ICharacter attacker);

        void Cure();
    }
}