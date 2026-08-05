using GameDevTV.Inventories;
using UnityEngine;

/*
 * This can be used to have the player run over an item 
 * to pick it up instead of clicking on it.  It needs to
 * be added to the Pickup prefab.
*/
namespace InventoryExample.Control
{
    [RequireComponent(typeof(Pickup))]
    public class RunoverPickup : MonoBehaviour
    {
        private Pickup _pickup;
        private Collider _collider;

        private void Awake()
        {
            _pickup = GetComponent<Pickup>();
            /*
             * The collider must be set to is trigger
             * for the code to work.
            */
            _collider = GetComponent<Collider>();
            _collider.isTrigger = true;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                _pickup.PickupItem();
            }
        }
    }
}