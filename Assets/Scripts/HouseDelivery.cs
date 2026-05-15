using UnityEngine;

public class HouseDelivery : MonoBehaviour
{
    public int reward = 100;

    public GameObject marker;

    public bool isTargetHouse = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (DeliveryManager.instance.hasFood)
            {
                // Deliver food
                DeliveryManager.instance.DeliverFood(reward);

                // Play delivery sound
                AudioManager.instance.PlayDeliverySound();
                MessageUI.instance.ShowMessage("Delivery Complete!");
                // Hide marker
                if (marker != null)
                {
                    marker.SetActive(false);
                }

                // Reset target
                isTargetHouse = false;

                // Select next house
                OrderManager.instance.SelectRandomHouse();

                Debug.Log("Food Delivered!");
            }
        }
    }
}