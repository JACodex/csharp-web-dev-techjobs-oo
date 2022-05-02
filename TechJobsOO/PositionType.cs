using System;
namespace TechJobsOO
{
    public class PositionType
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }

        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods. ✅

        public PositionType(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is PositionType type &&
                   Value == type.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
        public override string ToString()
        {
            return Value;
        }
    }
}
