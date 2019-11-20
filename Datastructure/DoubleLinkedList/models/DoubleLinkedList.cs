using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedList.models
{
    class DoubleLinkedList<T> where T : class
    {
        private DoubleLinkedListItem<T> _firstItem;
        private DoubleLinkedListItem<T> _lastItem;

        public DoubleLinkedList()
        {
            this._firstItem = null;
            this._lastItem = null;
        }
        public DoubleLinkedList(T item)
        {
            this._firstItem = new DoubleLinkedListItem<T>(item, null, null);
            this._lastItem = _firstItem;
        }

        public DoubleLinkedList(DoubleLinkedList<T> dll)
        {
            this._firstItem = dll._firstItem;
            this._lastItem = dll._lastItem;

        }


        public bool Add(T itemToAdd)
        {
            if (itemToAdd == null)
            {
                return false;
            }

            if (this._firstItem == null)
            {
                this._firstItem = new DoubleLinkedListItem<T>(itemToAdd, null, null);
                this._lastItem = this._firstItem;
                return true;
            }

            else
            {
                this._lastItem.NextItem = new DoubleLinkedListItem<T>(itemToAdd, null, _lastItem)
;
                this._lastItem = this._lastItem.NextItem;
                return true;
            }


        }

        public bool AddAfter(T itemToAdd, T itemToFind)
        {
            if (itemToAdd == null)
            {
                return false;

            }

            if (itemToFind == null)
            {
                return false;
            }

            DoubleLinkedListItem<T> actItem = Find(itemToFind);

            if (actItem == null)
            {
                return false;
            }
            else
            {
                if (actItem == this._lastItem)
                {
                    Add(itemToAdd);
                    return true;
                }
                else
                {
                    actItem.NextItem = new DoubleLinkedListItem<T>(itemToAdd, actItem.NextItem, actItem);
                    actItem.NextItem.NextItem.BeforeItem = actItem.NextItem;
                    return true;
                }
            }

        }

        public DoubleLinkedListItem<T> Find(T itemToFind)
        {
            if (itemToFind == null)
            {
                return null;
            }

            if (this._firstItem != null)
            {
                DoubleLinkedListItem<T> actItem = this._firstItem;
                while (actItem != null)
                {
                    if (actItem.Item.Equals(itemToFind))
                    {
                        return actItem;
                    }
                    actItem = actItem.NextItem;
                }
            }
            else
            {
                return null;
            }

            return null;

        }

        public bool Remove(T itemToRemove)
        {
            if (itemToRemove == null)
            {
                return false;
            }

            DoubleLinkedListItem<T> actItem = Find(itemToRemove);

            // 1.Fall
            if (actItem.BeforeItem == null)
            {
                this._firstItem = actItem.NextItem;
                this._firstItem.BeforeItem = null;
                return true;
            }

            // 2. Fall
            else if (actItem.NextItem == null)
            {
                this._lastItem = actItem.BeforeItem;
                this._lastItem.NextItem = null;
                return true;
            }
            // 3.Fall
            else
            {
                actItem.BeforeItem.NextItem = actItem.BeforeItem;
                actItem.NextItem.BeforeItem = actItem.NextItem;
                return true;

            }

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

            DoubleLinkedListItem<T> actItem = Find(itemToChange);

            if (actItem == null)
            {
                return false;
            }
            else
            {
                actItem.Item = itemNewData;
                return true;
            }





        }

        public override string ToString()
        {
            string s = "";

            if (this._firstItem != null)
            {
                DoubleLinkedListItem<T> actItem = this._firstItem;
                while (actItem != null)
                {
                    s += actItem.Item.ToString() + "\n";
                    actItem = actItem.NextItem;
                }
            }

            if (s == "")
            {
                return "no item";
            }
            return s;
        }

        public DoubleLinkedListItem<T> FindRecursiv(T itemToFind, DoubleLinkedListItem<T> actItem = null)
        {
            // Parameter überprüfen
            if (itemToFind == null)
            {
                return null;
            }

            // ist die DLL leer
            if (this._firstItem == null)
            {
                return null;
            }

            // actItem == null bedeutet, dass FindRecursiv am Beginn der DLL starten soll
            if (actItem == null)
            {
                actItem = this._firstItem;
            }

            // ansonsten, soll der Zeiger auf das nächste Element gesetzt werden
            else
            {
                actItem = actItem.NextItem;
            }

            // actItem wird normalerweise auf actItem.NextItem gesetzt+
            // => actItem könnte null sein (Ende der Liste)
            if (actItem == null)
            {
                return null;
            }

            // ist das aktuelle Element das gesuchte Element
            else if (actItem.Item.Equals(itemToFind))
            {
                return actItem;
            }

            // ansonsten wurde das Element noch nicht gefunden und das Ende der Liste wurde noch nicht erreicht
            else
            {
                // rekursiver Aufruf
                return FindRecursiv(itemToFind, actItem);
            }

        }
    }
}
