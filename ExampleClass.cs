using System;
using System.Collections;
using System.Threading;

namespace csharp_layout
{
    public abstract class ExampleClass : IEquatable<ExampleClass>, ICloneable, ICollection, ExampleClass.ITestInternal
    {
        private string Foo()
        {
            return null;
        }

        public int Bar()
        {
            return 0;
        }

        public int _x1;
        private int _a2;
        protected internal readonly int _m3 = 5;
        private int _count;
        private bool _isSynchronized;
        private object _syncRoot;

        int ICollection.Count => _count;

        public bool IsSynchronized => _isSynchronized;
        
        private ExampleClass(int x)
        {
        }

        public int Mm102 { get; }
        public int Aa103 { get; }

        public ExampleClass()
        {
        }

        internal interface ITestInternal
        {
            string Test1();
            string Test2();
        }
        
        internal static int _x4;
        public const int Q5 = 1;
        private const int B6 = 2;

        public ExampleClass(string x)
        {
        }

        protected int Dd104 { get; set; }

        static ExampleClass()
        {
            // Static constructors are always private, so will never appear in API documentation
        }

        internal protected struct InnerStruct
        {
            public string FieldValue;
        }
        
        public event EventHandler<string> YyEvent; 

        public event EventHandler<string> RrEvent {
            add { }
            remove { }
        }

        public delegate string UuuDelegate(int a, int b);

        public class JjjInner
        {
            public string Pppp { get; set; }
        }
        
        internal event EventHandler<int> TtEvent;
        
        protected abstract void Internal();

        protected ExampleClass(bool x)
        {
            const string Note1 = "Public, or even protected, inner classes are rare";
        }

        public string this[int i]
        {
            get { return null; }
            set { }
        }
        
        public bool Equals(ExampleClass other)
        {
            throw new NotImplementedException();
        }

        private class Wwww
        {
            public int Hhh { get; set; }
            public int Fff { get; set; }
        }
        
        void ICollection.CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        private enum Blah
        {
            Unknown = 0,
            ThisIsRatherRare = 1,
            ToHaveInternalDefinitions = 2, 
            ButDoesSometimesHappen =3 
        }

        ~ExampleClass()
        {
            // Destructors (finalizers) are always private, so will never appear in API documentation
            throw new NotImplementedException();
        }
        
        public static string operator +(ExampleClass a, ExampleClass b)
        {
            return "Operators must be public and static";
        }

        protected static int Eeee(int x)
        {
            return 1;
        }
        
        public object Clone()
        {
            return "Interface implementations must be either public";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return "Or must be explicitly implemented".GetEnumerator();
        }

        public virtual string Test2()
        {
            return "Even internal interfaces must be public (or explicit)";
        }

        object ICollection.SyncRoot => _syncRoot;
        
        string ITestInternal.Test1()
        {
            return null;
        }

        public abstract int Test3();
    }
}