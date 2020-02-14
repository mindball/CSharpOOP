
namespace PetClinics
{
    using Exception;
    public class Pet
    {
        private int age;
        public Pet(string name, string typeOfPet, int age)
        {
            this.Name = name;
            this.TypeOfPet = typeOfPet;
            this.Age = age;
        }
        public string Name { get; }
        public string TypeOfPet { get; }
        public int Age
        {
            get => this.age;
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new InvalidAgeException();
                }
                this.age = value;
            }

        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age} {this.TypeOfPet}";
        }
    }
}
