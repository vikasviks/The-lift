using System;
using System.Collections.Generic;
using System.Text;

namespace Lift.Entities
{
    public class Lift
    {
        public int Capacity { get; set; }
        public List<Person> People { get; set; }
        public int CurrentFloor { get; set; }

        public Lift(int capacity)
        {
            this.CurrentFloor = 0;
            this.Capacity = capacity;
        }

        private void MoveUp()
        {

        }

        private void MoveDown()
        {

        }
    }
}
