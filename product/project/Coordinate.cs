using System;
using System.Globalization;

namespace mars.rover
{
    public class Coordinate : IEquatable<Coordinate>
    {
        uint coordinate;

        public Coordinate(uint coordinate)
        {
            this.coordinate = coordinate;
        }

        public virtual void increment()
        {
            coordinate++;
        }

        public virtual void decrement()
        {
            coordinate--;
        }

        static public implicit operator Coordinate(uint coordinate)
        {
            return new Coordinate(coordinate);
        }

        public bool Equals(Coordinate other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.coordinate == coordinate;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (Coordinate)) return false;
            return Equals((Coordinate) obj);
        }

        public override int GetHashCode()
        {
            return coordinate.GetHashCode();
        }

        public override string ToString()
        {
            return coordinate.ToString(CultureInfo.InvariantCulture);
        }
    }
}