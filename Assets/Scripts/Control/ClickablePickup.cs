using GameDevTV.Inventories;
using UnityEngine;

namespace InventoryExample.Control
{
    [RequireComponent(typeof(Pickup))]
    public class ClickablePickup : MonoBehaviour, IRaycastable
    {
        Pickup pickup;

        private void Awake()
        {
            pickup = GetComponent<Pickup>();
        }

        /*
         * From IRaycastable
        */

        /*
         * Add a distance check so that the player cannot
         * pick up an item across the scene.
        */
        public CursorType GetCursorType()
        {
            if (pickup.CanBePickedUp())
            {
                return CursorType.Pickup;
            }
            else
            {
                return CursorType.FullPickup;
            }
        }

        /*
         * TO DO
         * Convert to new input method
        */

        /*
         * From IRaycastable
        */
        public bool HandleRaycast(PlayerController callingController)
        {
            if (Input.GetMouseButtonDown(0))
            {
                pickup.PickupItem();
            }
            return true;
        }
    }
}