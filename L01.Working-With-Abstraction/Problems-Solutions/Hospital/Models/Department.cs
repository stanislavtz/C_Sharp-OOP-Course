using System;

namespace P04_Hospital.Models
{
    public class Department
    {
        private const int NUMBER_ROOMS = 20;

        public Department(string name)
        {
            this.Name = name;
            this.Rooms = new Room[NUMBER_ROOMS];

            CreateRooms();
        }

        public string Name { get; private set; }
       

        public Room[] Rooms { get; }

        private void CreateRooms()
        {

            for (int i = 0; i < NUMBER_ROOMS; i++)
            {
                this.Rooms[i] = new Room();
            }
        }
    }
}