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
            int Test1();
            int Test2();
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

        }

        public event EventHandler<string> YyEvent; 

        public event EventHandler<string> RrEvent {
            add { }
            remove { }
        }

        public delegate int UuuDelegate(int a, int b);

        public class JjjInner
        {
            public string Pppp { get; set; }
        }
        
        internal event EventHandler<int> TtEvent;
        
        protected abstract void Internal();

        protected ExampleClass(bool x)
        {
            
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
            Thing = 1
        }

        public static int operator +(ExampleClass a, ExampleClass b)
        {
            return 0;
        }

        protected static int Eeee(int x)
        {
            return 1;
        }
        
        object ICloneable.Clone()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        object ICollection.SyncRoot => _syncRoot;

        int ITestInternal.Test1()
        {
            return 0;
        }

        public abstract int Test2();
    }
}