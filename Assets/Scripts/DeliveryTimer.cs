using UnityEngine;
using TMPro;

public class DeliveryTimer : MonoBehaviour
{
    public static DeliveryTimer instance;

    public float deliveryTime = 30f;

    private float currentTime;
    private bool timerRunning = false;

    public TextMeshProUGUI timerText;
    public TextMeshProUGUI resultText;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        timerText.text = "";
        resultText.text = "";
    }

    void Update()
    {
        if (timerRunning)
        {
            currentTime -= Time.deltaTime;

            // SHOW TIMER
            timerText.text = "Delivery Time : " + Mathf.Ceil(currentTime).ToString();

            // FAILED DELIVERY
            if (currentTime <= 0)
            {
                currentTime = 0;

                timerRunning = false;

                timerText.text = "";

                resultText.color = Color.red;
                resultText.text = "ORDER FAILED";

                MessageUI.instance.ShowMessage("Delivery Failed!");

                // RESET FOOD
                FoodPickup.hasFood = false;

                Debug.Log("DELIVERY FAILED");
            }
        }
    }

    // START DELIVERY TIMER
    public void StartDelivery()
    {
        currentTime = deliveryTime;

        timerRunning = true;

        timerText.gameObject.SetActive(true);

        timerText.color = Color.white;
        timerText.text = "Delivery Time : 30";

        resultText.text = "";

        Debug.Log("TIMER STARTED");
    }

    // STOP DELIVERY TIMER
    public void StopDelivery()
    {
        timerRunning = false;

        timerText.text = "";

        resultText.color = Color.green;
        resultText.text = "ORDER DELIVERED";

        Debug.Log("DELIVERY SUCCESS");
    }
}