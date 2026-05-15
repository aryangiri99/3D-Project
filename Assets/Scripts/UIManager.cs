using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI moneyText;

    void Update()
    {
        moneyText.text =
        "Money: $" +
        DeliveryManager.instance.money;
    }
}