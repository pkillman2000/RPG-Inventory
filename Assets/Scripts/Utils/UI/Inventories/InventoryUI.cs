using GameDevTV.Inventories;
using UnityEngine;

namespace GameDevTV.UI.Inventories
{
    /// <summary>
    /// To be placed on the root of the inventory UI. Handles spawning all the
    /// inventory slot prefabs.
    /// </summary>
    public class InventoryUI : MonoBehaviour
    {
        // CONFIG DATA
        [SerializeField] InventorySlotUI InventoryItemPrefab = null;

        // CACHE
        Inventory playerInventory;

        // LIFECYCLE METHODS

        private void Awake()
        {
            playerInventory = Inventory.GetPlayerInventory();
            playerInventory.inventoryUpdated += Redraw;
        }

        private void Start()
        {
            Redraw();
        }

        // PRIVATE

        // This is called by Start and whenever the
        // inventoryUpdated event happens.
        private void Redraw()
        {
            // Clear all slots in Inventory UI
            foreach (Transform child in transform)
            {
                Destroy(child.gameObject);
            }

            // Repopulate the slots with current inventory
            for (int i = 0; i < playerInventory.GetSize(); i++)
            {
                var itemUI = Instantiate(InventoryItemPrefab, transform);
                itemUI.Setup(playerInventory, i);
            }
        }
    }
}