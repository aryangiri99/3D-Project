using UnityEngine;

public class DeliveryManager : MonoBehaviour
{
    public static DeliveryManager instance;

    public bool hasFood = false;

    public int money = 0;

    public GameObject pizzaBox;

    private void Awake()
    {
        instance = this;
    }

    // PICKUP FOOD
    public void PickupFood()
    {
        hasFood = true;

        if (pizzaBox != null)
        {
            pizzaBox.SetActive(true);
        }

        Debug.Log("Food Picked!");
    }

    // DELIVER FOOD
    public void DeliverFood(int reward)
    {
        hasFood = false;

        if (pizzaBox != null)
        {
            pizzaBox.SetActive(false);
        }

        money += reward;

        Debug.Log("Food Delivered!");
        Debug.Log("Money = " + money);
    }
}