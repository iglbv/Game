using System;
using System.Collections.Generic;

namespace Fight
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Warrior> players = new List<Warrior>();
            players.Add(new Warrior("charmander", 100, 10, 10));
            players.Add(new Warrior("chip", 100, 10, 10));
            players.Add(new Warrior("subzero", 100, 10, 10));
            players.Add(new Warrior("donatello", 100, 10, 10));
            players.Add(new Warrior("link", 100, 10, 10));
            players.Add(new Warrior("mario", 100, 10, 10));
            players.Add(new Warrior("megaman", 100, 10, 10));
            Battle battle = new Battle(players);
        }
    }
}