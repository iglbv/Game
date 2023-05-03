using System;

namespace Fight
{
    public class Warrior
    {
        public string Name { get; set; } = "Warrior";
        private double health = 0;
        public double Health
        public int AttackMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;
        public bool IsDead { get; set; } = false;
        public Warrior(string name, double health = 0, int attackMax = 0, double blockMax = 0)
        {
            this.Name = name;
            this.Health = health;
            this.AttackMax = attackMax;
            this.BlockMax = blockMax;
        }
        public double GetAttack()
        {
          
        }
        public double GetBlock()
        {
       
        }
    }
}