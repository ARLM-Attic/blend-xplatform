using System;

namespace xPlatform.Flags
{
    [Serializable]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class TodoAttribute : Attribute
    {
        public TodoAttribute(string memo)
            : base()
        {
            this.Memo = memo;
        }

        private string memo = String.Empty;

        public string Memo
        {
            get { return this.memo; }
            set { this.memo = value ?? String.Empty; }
        }
    }
}
