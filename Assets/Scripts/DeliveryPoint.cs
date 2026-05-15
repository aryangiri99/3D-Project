using UnityEngine;

public class DeliveryPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // CHECK PLAYER
        if (other.CompareTag("Player"))
        {
            Debug.Log("PLAYER ENTERED HOUSE");

            // CHECK IF PLAYER HAS FOOD
            if (FoodPickup.hasFood == true)
            {
                Debug.Log("DELIVERY SUCCESS");

                // STOP TIMER
                DeliveryTimer.instance.StopDelivery();

                // REMOVE FOOD
                FoodPickup.hasFood = false;

                // GIVE MONEY
                DeliveryManager.instance.DeliverFood(100);

                // PLAY DELIVERY SOUND
                AudioManager.instance.PlayDeliverySound();

                // SHOW MESSAGE
                MessageUI.instance.ShowMessage("Food Delivered!");
            }
        }
    }
}