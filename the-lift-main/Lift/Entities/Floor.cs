using Lift.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lift.Entities
{
    public class Floor
    {
        public event ButtonPressedForCallingTheLiftOnAGivenFloor ButtonPressedForCallingTheLift;
        public int FloorNumber { get; set; }

        public List<Person> PeopleWaitingForLift { get; set; }

        public List<Person> PeopleBelongToTheFloor { get; set; }

        public Floor(int floorNumber, int[] floorNumbersPeopleWantToGoTo)
        {
            this.FloorNumber = floorNumber;
            this.PeopleWaitingForLift = floorNumbersPeopleWantToGoTo.Select(floorNumberPersonWantToGoTo =>
            {
                var person = new Person(floorNumber, floorNumberPersonWantToGoTo);
                person.ButtonPressed += this.ButtonPress;
                return person;
            }).ToList();
        }

        public void ButtonPress(Direction direction)
        {
            this.ButtonPressedForCallingTheLift(direction, this.FloorNumber);
        }
      //  static void Main()
        //{
           // Console.WriteLine("hello");
       // }

    }
}
