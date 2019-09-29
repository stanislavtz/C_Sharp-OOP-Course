using System;

namespace P04_Hospital.Models
{
    public class Department
    {
        private const int NUMBER_ROOMS = 20;

        private string name;

        public Department(string name)
        {
            this.Name = name;
            this.Rooms = new Room[NUMBER_ROOMS];

            CreateRooms();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value.Length < 1 || value.Length >= 100)
                {
                    throw new ArgumentException("Invalid department name length!");
                }

                this.name = value;
            }
        }

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