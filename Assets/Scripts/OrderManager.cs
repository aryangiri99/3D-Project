using UnityEngine;

public class OrderManager : MonoBehaviour
{
    public static OrderManager instance;

    public HouseDelivery[] houses;

    int currentHouse = -1;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        SelectRandomHouse();
    }

    public void SelectRandomHouse()
    {
        // Disable old house
        if(currentHouse != -1)
        {
            houses[currentHouse].isTargetHouse = false;
            houses[currentHouse].marker.SetActive(false);
        }

        // Random new house
        currentHouse = Random.Range(0, houses.Length);

        houses[currentHouse].isTargetHouse = true;

        houses[currentHouse].marker.SetActive(true);

        Debug.Log("Deliver To: " + houses[currentHouse].name);
    }

    public int GetCurrentHouse()
    {
        return currentHouse;
    }
}