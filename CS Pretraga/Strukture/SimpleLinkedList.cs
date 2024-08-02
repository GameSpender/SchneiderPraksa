using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPretraga.Strukture
{
    /// <summary>
    /// Jednostruko povezana lista <see cref="Podatak"/>-a
    /// </summary>
    internal class SimpleLinkedList
    {
        /// <summary>
        /// Element liste
        /// </summary>
        class Node
        {
            /// <summary>
            /// Vrednost elementa
            /// </summary>
            public Podatak Value;

            /// <summary>
            /// Referenca na sledeći element
            /// </summary>
            public Node? Next;

            public Node(Podatak value) { Value = value; }
        }

        Node? root;
        Node? last;
        public int Count { get; private set; } = 0;

        /// <summary>
        /// Dodaje podatak na kraj liste
        /// </summary>
        public void Add(Podatak value)
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
        public Podatak? Find(int id)
        {
            Node? current = root;

            while (current != null)
            {
                if (current.Value.Id == id)
                {
                    return current.Value;
                }
                current = current.Next;
            }
            return null;
        }
    }
}
