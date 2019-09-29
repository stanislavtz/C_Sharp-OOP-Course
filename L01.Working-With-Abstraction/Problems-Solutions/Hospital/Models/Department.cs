using System;
using System.Collections.Generic;

namespace P04_Hospital.Models
{
    public class Department
    {
        private const int NUMBER_ROOMS = 20;

        private string name;
        private readonly List<Room> rooms;

        public Department(string name)
        {
            this.Name = name;
            this.rooms = new List<Room>();

            CreateRooms();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (!(value.Length > 1 || value.Length < 100))
                {
                    throw new ArgumentException();
                }

                this.name = value;
            }
        }

        public IReadOnlyList<Room> Rooms => rooms.AsReadOnly();

        private void CreateRooms()
        {

            for (int i = 0; i < NUMBER_ROOMS; i++)
            {
                this.rooms.Add(new Room());
            }
        }
    }
}