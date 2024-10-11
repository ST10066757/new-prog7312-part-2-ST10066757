using System;
using System.Collections;
using System.Collections.Generic;

namespace MunicipalServiceApp
{
    public class PriorityQueue<TElement, TPriority> : IEnumerable<TElement>
        where TPriority : IComparable<TPriority>
    {
        private List<(TElement Element, TPriority Priority)> _heap = new List<(TElement, TPriority)>();

        public int Count => _heap.Count;

        public PriorityQueue()
        {
        }

        // Copy constructor
        public PriorityQueue(PriorityQueue<TElement, TPriority> other)
        {
            foreach (var item in other._heap)
            {
                this.Enqueue(item.Element, item.Priority);
            }
        }

        public void Enqueue(TElement element, TPriority priority)
        {
            _heap.Add((element, priority));
            HeapifyUp(_heap.Count - 1);
        }

        public TElement Dequeue()
        {
            if (_heap.Count == 0)
                throw new InvalidOperationException("The priority queue is empty.");

            TElement root = _heap[0].Element;
            _heap[0] = _heap[_heap.Count - 1];
            _heap.RemoveAt(_heap.Count - 1);
            HeapifyDown(0);
            return root;
        }

        public TElement Peek()
        {
            if (_heap.Count == 0)
                throw new InvalidOperationException("The priority queue is empty.");

            return _heap[0].Element;
        }

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parent = (index - 1) / 2;
                if (_heap[index].Priority.CompareTo(_heap[parent].Priority) >= 0)
                    break;

                Swap(index, parent);
                index = parent;
            }
        }

        private void HeapifyDown(int index)
        {
            int lastIndex = _heap.Count - 1;
            while (true)
            {
                int leftChild = 2 * index + 1;
                int rightChild = 2 * index + 2;
                int smallest = index;

                if (leftChild <= lastIndex && _heap[leftChild].Priority.CompareTo(_heap[smallest].Priority) < 0)
                {
                    smallest = leftChild;
                }

                if (rightChild <= lastIndex && _heap[rightChild].Priority.CompareTo(_heap[smallest].Priority) < 0)
                {
                    smallest = rightChild;
                }

                if (smallest == index)
                    break;

                Swap(index, smallest);
                index = smallest;
            }
        }

        private void Swap(int i, int j)
        {
            var temp = _heap[i];
            _heap[i] = _heap[j];
            _heap[j] = temp;
        }

        // Implement the generic GetEnumerator method
        public IEnumerator<TElement> GetEnumerator()
        {
            foreach (var item in _heap)
            {
                yield return item.Element;
            }
        }

        // Explicit implementation of the non-generic IEnumerable.GetEnumerator
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        // Clone method to create a copy of the PriorityQueue
        public PriorityQueue<TElement, TPriority> Clone()
        {
            var clone = new PriorityQueue<TElement, TPriority>(this);
            return clone;
        }
    }
}