using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Player
    {
        private Guid id;
        private int points;

        public Player(string name)
        {
            id = new Guid();
            Name = name;
        }

        public Guid Id { 
            get { return id; } 
        }

        public string Name { get; set; }

        public int Points
        {
            get { return points; }
        }


        public void SubtractPoints(int damage)
        {
            points -= damage;
            if (points < 0)
            {
                points = 0;
            }
        }

        public void SetPoints(int points)
        {
            this.points = points;
        }

        public void AddPoints(int heal)
        {
            points += heal;
        }
    }
}
