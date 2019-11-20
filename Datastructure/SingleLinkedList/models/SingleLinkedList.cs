using System;
using System.Collections.Generic;
using System.Text;

namespace SingleLinkedList.models
{
    // generic
    class SingleLinkedList<T> where T : class
    {

        private SingleLinkedListItem<T> _firstItem;
        private SingleLinkedListItem<T> _lastItem;

        public SingleLinkedList()
        {
            this._firstItem = null;
            this._lastItem = null;
        }

        public SingleLinkedList(T item)
        {
            this._firstItem = new SingleLinkedListItem<T>(item, null);
            this._lastItem = _firstItem;
        }
            
        public SingleLinkedList(SingleLinkedList<T> sll)
        {
            this._firstItem = sll._firstItem;
            this._lastItem = sll._lastItem;
        }


        // Methode Add
        public bool Add(T itemToAdd)
        {
            // 1. Parameter überprüfen
            if(itemToAdd == null)
            {
                return false;
            }

            // 1. Fall: die SLL ist leer
            if(this._firstItem == null)
            {
                this._firstItem = new SingleLinkedListItem<T>(itemToAdd, null);
                this._lastItem = this._firstItem;
            }

            // 2.Fall: die SLL ist nicht leer
            else
            {
                this._lastItem.NextItem = new SingleLinkedListItem<T>(itemToAdd, null);
                this._lastItem = this._lastItem.NextItem;
            }

            return true;
        }

        public void AddAfter(T itemToAdd, T itemToFind)
        {
            SingleLinkedListItem<T> actItem = this._firstItem;

            do
            {
                if (actItem.Item.Equals(itemToFind))
                {
                    actItem.NextItem = new SingleLinkedListItem<T>(itemToAdd, null);
                    actItem = actItem.NextItem;
                }
                else
                {
                    Add(itemToAdd);
                }

            } while (actItem == this._lastItem);
        }

        public bool Remove(T itemToRemove)


        {
            if (itemToRemove == null)
            {
                return false;
            }

            // es existiert noch kein Eintrag in der Liste
            if (this._firstItem == null)
            {
                return false;
            }

            bool isFirstItem;
            SingleLinkedListItem<T> itemBeforeItemToRemove = this.FindItemBeforeItemToFind(itemToRemove, out isFirstItem);
           
            // Item ist nicht vorhanden
            if((itemBeforeItemToRemove == null) && !isFirstItem)
            {
                return false;
            }


            // 1ter Fall: 1ter Eintrag
            // 1ter Eintrag ist der gesuchte Eintrag
            if(isFirstItem)
            {
                this._firstItem = this._firstItem.NextItem;
                return true;
            }

            // 2ter Fall: irgendwo zw. _firstItem und _lastItem
            if(itemBeforeItemToRemove.NextItem.NextItem == null)
            {
                this._lastItem = itemBeforeItemToRemove;
                this._lastItem.NextItem = null;
                return true;
            }

            // 3ter Fall: es handelt sich um den letzten Eintrag
            else
            {
                itemBeforeItemToRemove.NextItem = itemBeforeItemToRemove.NextItem.NextItem;
                return true;
            }

        }

        public SingleLinkedListItem<T> Find (T itemToFind)
        {
            if(itemToFind == null)
            {
                return null;
            }

            if(this._firstItem == null)
            {
                return null;
            }

            SingleLinkedListItem<T> actItem = this._firstItem;
            

            while (actItem != null)
            {
                if (actItem.Item.Equals(itemToFind))
                {
                    return actItem;
                }               
                    actItem = actItem.NextItem;              
            }
            return null;
        }

        public SingleLinkedListItem<T> FindItemBeforeItemToFind(T itemToFind, out bool isStartItem)
        {
            isStartItem = false;
            if(itemToFind == null)
            {
                return null;
            }

            if(this._firstItem == null)
            {
                return null;
            }

            if (this._firstItem.Item.Equals(itemToFind))
            {
                isStartItem = true;
                return null;
            }

            SingleLinkedListItem<T> actItem = this._firstItem;
            while(actItem != null)
            {
                if((actItem.NextItem != null) && (actItem.NextItem.Item.Equals(itemToFind)))
                {
                    return actItem;
                }
                actItem = actItem.NextItem;
            }
            return null;
        }

        public bool Change(T itemToChange, T itemNewData)
        {
            if ((itemToChange == null) || (itemNewData == null))
            {
                return false;
            }

            
            if (this._firstItem == null)
            {
                return false;
            }
           
            SingleLinkedListItem<T> foundItem = Find(itemToChange);

           
            if (foundItem == null)
            {
                return false;
            }
            else
            {
                 foundItem.Item = itemNewData;
                 return true;              
            }


            
        }



        public override string ToString()
        {
            string s = "";

            if(this._firstItem != null)
            {
                SingleLinkedListItem<T> actItem = this._firstItem;
                while (actItem != null)
                {
                    s += actItem.Item.ToString() + "\n";
                    actItem = actItem.NextItem;
                }
            }

            if(s == "")
            {
                return "no item";
            }
            return s;
        }

       
    }
}
