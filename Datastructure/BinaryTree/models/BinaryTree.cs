using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree.models
{
    class BinaryTree
    {
        private BinaryTreeItem _root;


        private BinaryTreeItem _root3;


        private BinaryTreeItem _root2;
        
        public BinaryTree()
        {
            this._root = null;

            this._root2 = null;

            this._root2 = _root;

        }

        public BinaryTree(int item)
        {
            this._root = new BinaryTreeItem(item, 0, null, null);
            
            this._root = 5;
        }

        public BinaryTree(BinaryTree bt)
        {
            this._root = bt._root;
            this._root = _root;
        }

        public int Counter { get; private set; }




        public void IncreaseCounter()
        {
            this.Counter++;
            Counter = Counter+1;
            Counter = Counter + 5;
            Counter = Counter * 2;
            Counter = Counter * 6;
            Counter = Counter *10;
        }

        public bool Add(int itemToAdd)
        {
            if (this._root == null)
            {
                this._root = new BinaryTreeItem(itemToAdd, 1, null, null);
                IncreaseCounter();
                return true;

            }
            else
            {
                BinaryTreeItem actItem = _root;
                while (actItem != null)
                {
                    if (itemToAdd > actItem.Item)
                    {
                        if (actItem.RightItem == null)
                        {
                            actItem.RightItem = new BinaryTreeItem(itemToAdd, 1, null, null);
                            IncreaseCounter();
                            return true;
                        }
                        actItem = actItem.RightItem;
                    }
                    else if (itemToAdd < actItem.Item)
                    {
                        if (actItem.LeftItem == null)
                        {
                            actItem.LeftItem = new BinaryTreeItem(itemToAdd, 1, null, null);
                            IncreaseCounter();
                            return true;
                        }
                        actItem = actItem.LeftItem;
                    }
                    else
                    {
                        actItem.Count = actItem.Count + 1;
                        return true;
                    }
                }
                return false;
            }
        }

        public BinaryTreeItem Find(int itemToFind)
        {
            if (itemToFind == 0)
            {
                return null;
            }

            BinaryTreeItem actItem = this._root;

            while (actItem != null)
            {
                if (itemToFind > actItem.Item)
                {
                    actItem = actItem.RightItem;
                }
                else if (itemToFind < actItem.Item)
                {
                    actItem = actItem.LeftItem;
                }
                else
                {
                    return actItem;
                }

            }
            return null;
        }

        public BinaryTreeItem FindMin(int searchFrom = 0)
        {

            if (searchFrom == 0)
            {
                BinaryTreeItem actItem = _root;

                while (actItem != null)
                {
                    if (actItem.LeftItem == null)
                    {
                        return actItem;
                    }
                    actItem = actItem.LeftItem;
                }
            }

            else
            {
                BinaryTreeItem actItem = Find(searchFrom);

                while (actItem != null)
                {
                    if (actItem.LeftItem == null)
                    {
                        return actItem;
                    }
                    actItem = actItem.LeftItem;
                }

            }
            return null;
        }

        public BinaryTreeItem FindMax(int searchFrom = 0)
        {
            if (searchFrom == 0)
            {
                BinaryTreeItem actItem = _root;

                while (actItem != null)
                {
                    if (actItem.RightItem == null)
                    {
                        return actItem;
                    }
                    actItem = actItem.RightItem;
                }
            }

            else
            {
                BinaryTreeItem actItem = Find(searchFrom);

                while (actItem != null)
                {
                    if (actItem.RightItem == null)
                    {
                        return actItem;
                    }
                    actItem = actItem.RightItem;
                }

            }
            return null;
        }



        public BinaryTreeItem FindMaxRecursiv(int searchItem, BinaryTreeItem actItem = null)
        {

            if (this._root == null)
            {
                return null;
            }

            if ((searchItem == 0) && (actItem == null))
            {
                actItem = this._root;
            }

            if (actItem == null)
            {
                actItem = Find(searchItem);
            }

            if (actItem.RightItem == null)
            {
                return actItem;
            }

            else
            {
                actItem = actItem.RightItem;

            }
            return FindMaxRecursiv(searchItem, actItem);


        }

        public BinaryTreeItem FindMinRecursiv(int searchItem, BinaryTreeItem actItem = null)
        {

            if (this._root == null)
            {
                return null;
            }

            if ((searchItem == 0) && (actItem == null))
            {
                actItem = this._root;
            }

            if (actItem == null)
            {
                actItem = Find(searchItem);
            }

            if (actItem.LeftItem == null)
            {
                return actItem;
            }

            else
            {
                actItem = actItem.LeftItem;
            }
            return FindMinRecursiv(searchItem, actItem);


        }

        public BinaryTreeItem FindRecursiv(int itemToFind, BinaryTreeItem actItem = null)
        {
            if (itemToFind == 0)
            {
                return null;
            }

            if (this._root == null)
            {
                return null;
            }

            if (actItem == null)
            {
                actItem = this._root;
            }

            if (itemToFind > actItem.Item)
            {
                actItem = actItem.RightItem;
            }
            else if (itemToFind < actItem.Item)
            {
                actItem = actItem.LeftItem;
            }

            else
            {
                return actItem;
            }

            return FindRecursiv(itemToFind, actItem);
        }

        public bool AddRekursiv(int itemToAdd, BinaryTreeItem actItem = null)
        {
            if (_root == null)
            {
                this._root = new BinaryTreeItem(itemToAdd, 1, null, null);
                IncreaseCounter();
                return true;
            }

            if (actItem == null)
            {
                actItem = _root;
            }

            if (itemToAdd > actItem.Item)
            {
                if (actItem.RightItem == null)
                {
                    actItem.RightItem = new BinaryTreeItem(itemToAdd, 1, null, null);
                    IncreaseCounter();
                    return true;
                }
                actItem = actItem.RightItem;
            }
            else if (itemToAdd < actItem.Item)
            {
                if (actItem.LeftItem == null)
                {
                    actItem.LeftItem = new BinaryTreeItem(itemToAdd, 1, null, null);
                    IncreaseCounter();
                    return true;
                }
                actItem = actItem.LeftItem;
            }
            else
            {
                actItem.Count = actItem.Count + 1;
                IncreaseCounter();
                return true;
            }
            return AddRekursiv(itemToAdd, actItem);
        }



        public BinaryTreeItem FindItemBeforeItem(int itemToFind)
        {
            if (itemToFind == 0)
            {
                return null;
            }

            BinaryTreeItem actItem = this._root;

            while (actItem != null)
            {
                if (itemToFind > actItem.Item)
                {
                    if (actItem.RightItem.Item.Equals(itemToFind))
                    {
                        return actItem;
                    }
                    actItem = actItem.RightItem;
                }

                if (itemToFind < actItem.Item)
                {
                    if (actItem.LeftItem.Item.Equals(itemToFind))
                    {
                        return actItem;
                    }
                    actItem = actItem.LeftItem;
                }


            }
            return null;
        }




        public bool Remove(int itemToRemove)
        {
            //Fall a
            BinaryTreeItem actItem = Find(itemToRemove);
            if (actItem.Equals(_root))
            {
                return false;
            }
            BinaryTreeItem BeforeActItem = FindItemBeforeItem(itemToRemove);
             if (actItem.LeftItem == null)
            { 
                if (actItem.Item > BeforeActItem.Item)
                {
                    BeforeActItem.RightItem = actItem.RightItem;
                    return true;
                }
                if (actItem.Item < BeforeActItem.Item)
                {
                    BeforeActItem.LeftItem = actItem.RightItem;
                    return true;
                }
            }

            // Fall 2:
            else if (actItem.RightItem == null)
            {
                if (actItem.Item > BeforeActItem.Item)
                {
                    BeforeActItem.RightItem = actItem.LeftItem;
                    return true;
                }
                if (actItem.Item < BeforeActItem.Item)
                {
                    BeforeActItem.LeftItem = actItem.LeftItem;
                    return true;
                }
            }
            
            // Fall 3:
           else if(actItem.RightItem.LeftItem == null)
            {
                if (actItem.Item > BeforeActItem.Item)
                {
                    BeforeActItem.RightItem = actItem.RightItem;
                    actItem.RightItem.LeftItem = actItem.LeftItem;
                    return true;
                }
                if (actItem.Item < BeforeActItem.Item)
                {
                    BeforeActItem.LeftItem = actItem.RightItem;
                    actItem.RightItem.LeftItem = actItem.LeftItem;
                    return true;
                }
            }

            else if (actItem.LeftItem.RightItem == null)
            {
                if (actItem.Item > BeforeActItem.Item)
                {
                    BeforeActItem.RightItem = actItem.LeftItem;
                    actItem.LeftItem.RightItem = actItem.RightItem;
                    return true;
                }
                if (actItem.Item < BeforeActItem.Item)
                {
                    BeforeActItem.LeftItem = actItem.LeftItem;
                    actItem.LeftItem.RightItem = actItem.RightItem;
                    return true;
                }
            }

            //Fall 4:
            else
            {
                BinaryTreeItem minItem = FindMin(actItem.RightItem.Item);
                BinaryTreeItem beforeMinItem = FindItemBeforeItem(minItem.Item);

                if (actItem.Item > BeforeActItem.Item)
                {
                    minItem.LeftItem = actItem.LeftItem;
                    beforeMinItem.LeftItem = minItem.RightItem;
                    minItem.RightItem = actItem.RightItem;
                    BeforeActItem.RightItem = minItem;
                                                                   
                    return true;
                }
                if (actItem.Item < BeforeActItem.Item)
                {
                    minItem.LeftItem = actItem.LeftItem;
                    beforeMinItem.LeftItem = minItem.RightItem;
                    minItem.RightItem = actItem.RightItem;
                    BeforeActItem.LeftItem = minItem;
                    return true;
                }
            }

            return false;
        }




    }
   
}
    

    


    

