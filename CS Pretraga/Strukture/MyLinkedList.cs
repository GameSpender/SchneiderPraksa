using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPretraga.Strukture
{
    internal class MyLinkedList<T>
    {
        /// <summary>
        /// Element liste
        /// </summary>
        class Node
        {
            /// <summary>
            /// Vrednost elementa
            /// </summary>
            public T Value;

            /// <summary>
            /// Referenca na sledeći element
            /// </summary>
            public Node? Next;

            public Node(T value) { Value = value; }
        }

        Node? root;
        Node? last;
        public int Count { get; private set; } = 0;

        /// <summary>
        /// Dodaje element na kraj liste
        /// </summary>
        public void Add(T value)
        {
            if (root == null)
            {
                root = new Node(value);
                last = root;
            }
            else
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                last.Next = new Node(value);
#pragma warning restore CS8602
                last = last.Next;
            }
            Count++;
        }

        /// <summary>
        /// Nalazi prvi element koji zadovoljava predikat
        /// </summary>
        /// <returns>Prva pojava elementa ili null</returns>
        public T? Find(Predicate<T> p)
        {
            Node? current = root;

            while (current != null)
            {
                if (p(current.Value))
                {
                    return current.Value;
                }
                current = current.Next;
            }
            return default;
        }
    }
}
