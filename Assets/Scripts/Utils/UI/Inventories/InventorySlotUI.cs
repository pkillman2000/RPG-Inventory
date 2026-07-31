using GameDevTV.Core.UI.Dragging;
using UnityEngine;

namespace GameDevTV.UI.Inventories
{
    public class InventorySlotUI : MonoBehaviour, IDragContainer<Sprite>
    {
        // CONFIG DATA
        [SerializeField] InventoryItemIcon icon = null;

        // PUBLIC

        /*
         * How many sprite items of this type can you accept?
         * This is for stackable items like coins
        */
        public int MaxAcceptable(Sprite item)
        {
            if (GetItem() == null)
            {
                return int.MaxValue;
            }
            return 0;
        }

        /*
         * Takes sprite and number of items.
         * Designed for stackable items such as coins.
        */
        public void AddItems(Sprite item, int number)
        {
            icon.SetItem(item);
        }

        /*
         * Returns icon of current item.
        */
        public Sprite GetItem()
        {
            return icon.GetItem();
        }

        /*
         * Returns number of items in slot.
         * Designed for stackable items.
        */
        public int GetNumber()
        {
            return 1;
        }

        /*
         * Allows you to only move a certain
         * number of items from slot.
        */
        public void RemoveItems(int number)
        {
            icon.SetItem(null);
        }
    }
}