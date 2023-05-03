using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    public class Battle
    {
        private List<Warrior> warriors;
        public Battle(List<Warrior> warriors)
        {
            this.warriors = warriors;
            bool gameOver = false;
        }
        public bool PlayRound()
        {
            Warrior attacker = GetAttacker();
        }
        private Warrior GetAttacker()
        {
        
        }
        private bool IsGameOver()
        {

        }
        private bool IsDead(Warrior warrior)
        {
            return warrior.IsDead;
        }
        private void Fight(ref Warrior attacker, Warrior oponent)
        {
            double attack = attacker.GetAttack();
            double block = oponent.GetBlock();
            double attackerDamage = block - attack;
        }
    }
}