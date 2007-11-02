using System;

namespace Blend.xPlatform
{
    [Serializable]
    public class CompromisingType<T> : IEquatable<T>, IEquatable<CompromisingType<T>>
    {
        public CompromisingType(T defaultValue, bool isReadOnly)
        {
            this.innerVariable = defaultValue;
            this.isReadOnly = isReadOnly;
        }

        public CompromisingType(T defaultValue)
            : this(defaultValue, false)
        {
        }

        public CompromisingType(bool isReadOnly)
            : this(default(T), isReadOnly)
        {
        }

        public CompromisingType()
            : this(default(T), false)
        {
        }

        public CompromisingType(CompromisingType<T> anotherValue)
            : this(anotherValue.innerVariable, anotherValue.isReadOnly)
        {
        }

        private T innerVariable = default(T);

        [NonSerialized]
        private bool isReadOnly = false;

        public T InnerVariable
        {
            get { return this.innerVariable; }
            set
            {
                if (this.isReadOnly)
                    throw new InvalidOperationException("This variable is read-only.");

                this.innerVariable = value;
            }
        }

        public bool IsReadOnly
        {
            get { return this.isReadOnly; }
            set { this.isReadOnly = value; }
        }

        public static implicit operator T(CompromisingType<T> container)
        {
            return container.innerVariable;
        }

        public static implicit operator CompromisingType<T>(T innerVariable)
        {
            return new CompromisingType<T>(innerVariable);
        }

        public bool Equals(T other)
        {
            return this.innerVariable.Equals(other);
        }

        public bool Equals(CompromisingType<T> other)
        {
            return this.innerVariable.Equals(other.innerVariable);
        }

        public override bool Equals(object obj)
        {
            if (obj is T)
                return this.Equals((T)obj);
            else if (obj is CompromisingType<T>)
                return this.Equals(((CompromisingType<T>)obj).innerVariable);
            else
                return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return this.innerVariable.GetHashCode();
        }

        public override string ToString()
        {
            return this.innerVariable.ToString();
        }
    }
}
