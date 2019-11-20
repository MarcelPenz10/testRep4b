using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedList.models
{
    class DoubleLinkedListItem<T> where T : class
    {
        public T Item { get; set; }

        public DoubleLinkedListItem<T> NextItem { get; set; }
        public DoubleLinkedListItem<T> BeforeItem { get; set; }

        public DoubleLinkedListItem() : this(null, null, null) { }
        public DoubleLinkedListItem(T item, DoubleLinkedListItem<T> nextItem, DoubleLinkedListItem<T> beforeItem)
        {
            this.Item = item;
            this.NextItem = nextItem;
            this.BeforeItem = beforeItem;
        }

        public override string ToString()
        {
            return this.Item.ToString();
        }


    }
}
