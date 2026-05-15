using UnityEngine;

public class FoodPickup : MonoBehaviour
{
    public static bool hasFood = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hasFood = true;

            DeliveryTimer.instance.StartDelivery();

            MessageUI.instance.ShowMessage("Food Picked Up!");

            AudioManager.instance.PlayPickupSound();

            Debug.Log("FOOD PICKED");
        }
    }
}