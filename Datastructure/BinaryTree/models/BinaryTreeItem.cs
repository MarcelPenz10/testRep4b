using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree.models
{
    class BinaryTreeItem
    {
        public int Item { get; set; }
        public int Count { get; set; }

        public BinaryTreeItem RightItem { get; set; }
        public BinaryTreeItem LeftItem { get; set; }

        // ctors
        public BinaryTreeItem() : this(0, 0, null, null) { }
        public BinaryTreeItem(int item, int count, BinaryTreeItem rightItem, BinaryTreeItem leftItem)
        {
            this.Item = item;
            this.Count = count;
            this.RightItem = rightItem;
            this.LeftItem = leftItem;
        }


        public override string ToString()
        {
            return this.Item.ToString();
        }

    }
}
