﻿using System;
using System.Collections;
using System.Threading;

namespace csharp_layout
{
    public abstract class Class1 : IEquatable<Class1>, ICloneable, ICollection
    {
        private string Foo()
        {
        }

        public int Bar()
        {
        }

        public int _x1;
        private int _a2;
        protected internal readonly int _m3;
        private int _count;
        private bool _isSynchronized;
        private object _syncRoot;

        int ICollection.Count => _count;

        bool ICollection.IsSynchronized => _isSynchronized;
        
        private Class1(int x)
        {
        }

        public int Mm102 { get; }
        public int Aa103 { get; }

        public Class1()
        {
        }

        internal static int _x4;
        public const int Q5;
        private const int B6;

        public Class1(string x)
        {
        }

        protected int Dd104 { get; set; }

        static Class1()
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

        protected Class1(bool x)
        {
            
        }

        public string this[int i]
        {
            get { return null; }
            set { }
        }
        
        public bool Equals(Class1 other)
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

        public static int operator +(Class1 a, Class1 b)
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
    }
}