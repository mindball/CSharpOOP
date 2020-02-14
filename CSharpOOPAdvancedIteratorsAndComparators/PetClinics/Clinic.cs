namespace PetClinics
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using PetClinics.Exception;
    public class Clinic : IEnumerable<Room>, IComparable<Clinic>
    {
        private int roomCount;
        //private string name;
        private Room[] rooms;
        private int middleOfOddRoom;
        private int indexOfFirstFreeRoomOfClinic;

        public Clinic(string name, int countRoom)
        {
            this.Name = name;
            this.RoomCount = countRoom;
            this.rooms = new Room[this.RoomCount];
            this.middleOfOddRoom = (int)Math.Floor((this.RoomCount / 2.0));
        }
        public int RoomCount
        {
            get { return this.roomCount; }
            set
            {
                if ((value % 2 == 0) || value < 1 || value > 101)
                    throw new InvalidNumberOfRroomsException();

                this.roomCount = value;
            }
        }

        public string Name { get; set; }

        public bool AddPet(Pet newPet)
        {
            for (int i = 0; i < this.RoomCount; i++)
            {
                //Left
                if (this.rooms[this.middleOfOddRoom - i] == null)
                {
                    this.rooms[this.middleOfOddRoom - i] = new Room(newPet);
                    Console.WriteLine(true);
                    return true;
                }
                //Right
                if (this.rooms[this.middleOfOddRoom + i] == null)
                {
                    this.rooms[this.middleOfOddRoom + i] = new Room(newPet);
                    Console.WriteLine(true);

                    return true;
                }
            }

            Console.WriteLine(false);
            return false;
        }

        public bool ReleasePet()
        {
            for (int i = this.middleOfOddRoom; i < this.RoomCount; i++)
            {
                if (this.rooms[i] != null)
                {
                    this.rooms[i] = null;
                    Console.WriteLine(true);
                    return true;
                }
                else
                {
                    Console.WriteLine(false);
                    return false;
                }
            }

            for (int i = 0; i < this.middleOfOddRoom; i++)
            {
                if (this.rooms[i] != null)
                {
                    this.rooms[i] = null;
                    return true;
                }
            }

            return false;
        }

        public bool HasEmptyRooms()
        {
            indexOfFirstFreeRoomOfClinic = Array.IndexOf(rooms, null);
            if (indexOfFirstFreeRoomOfClinic == -1)
            {
                Console.WriteLine("false");
                return false;
            }
            else
            {
                //Console.WriteLine(indexOfFirstFreeRoomOfClinic);
                Console.WriteLine(true);
                return true;
            }
        }

        public IEnumerator<Room> GetEnumerator()
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                yield return this.rooms[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int CompareTo(Clinic clinicName)
        {
            return this.Name.CompareTo(clinicName.Name);
        }

        public Room this[int index]
        {
            get
            {
                if (index >= this.rooms.Length || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Invalid index: " + index);
                }
                return this.rooms[index];
            }
        }
    }
}
