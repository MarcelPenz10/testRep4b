using System;
using System.Collections.Generic;
using System.Text;

namespace SingleLinkedList.models
{
    // generic
    class SingleLinkedListItem<T> where T : class
    {
        public T Item { get; set; }

        // Referenz auf das nächste Item
        public SingleLinkedListItem<T> NextItem { get; set; }

        // ctors
        public SingleLinkedListItem() : this(null , null) { }
        public SingleLinkedListItem(T item, SingleLinkedListItem<T> nextItem)
        {
            this.Item = item;
            this.NextItem = nextItem;
        }

        public override string ToString()
        {
            return this.Item.ToString();
        }

    }
}
