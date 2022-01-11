using LinqTutorial.DataTypes;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LinqTutorial
{
    internal class PetEqualityComparer : IEqualityComparer<Pet>
    {
        public bool Equals(Pet x, Pet y)
        {
            return x.Id == y.Id && x.Name== y.Name && x.PetType == y.PetType && x.Weight == y.Weight;
        }

        public int GetHashCode([DisallowNull] Pet pet)
        {
            return pet.Id;
        }
    }
}