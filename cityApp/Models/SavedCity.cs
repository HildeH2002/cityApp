using System;

namespace cityApp
{
    internal class SavedCity : IEquatable<SavedCity>, IComparable<SavedCity>
    {
        public string City { get; set; }
        public string Info { get; set; }

        public SavedCity()
        {
        }

        public SavedCity(string city, string info)
        {
            City = city;
            Info = info;
        }

        public override int GetHashCode()
        {
            return City.GetHashCode();
        }

        public bool Equals(SavedCity other)
        {
            return City == other.City;
        }

        public int CompareTo(SavedCity other)
        {
            return City.CompareTo(other.City);
        }
    }
}