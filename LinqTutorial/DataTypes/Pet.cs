using System;

namespace LinqTutorial.DataTypes
{
    public class Pet: IComparable<Pet>
    {
        public int Id { get; }
        public string Name { get; }
        public PetType PetType { get; }
        public float Weight { get; }

        public Pet(int id, string name, PetType petType, float weight)
        {
            Id = id;
            Name = name;
            PetType = petType;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Type: {PetType}, Weight: {Weight}";
        }

        public int CompareTo(Pet other)
        {
            return Id.CompareTo(other.Weight);
        }
    }
}
