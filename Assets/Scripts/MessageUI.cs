using TMPro;
using UnityEngine;
using System.Collections;

public class MessageUI : MonoBehaviour
{
    public static MessageUI instance;

    public TextMeshProUGUI messageText;

    private void Awake()
    {
        instance = this;
    }

    public void ShowMessage(string message)
    {
        StopAllCoroutines();
        StartCoroutine(ShowMessageCoroutine(message));
    }

    IEnumerator ShowMessageCoroutine(string message)
    {
        messageText.text = message;

        yield return new WaitForSeconds(2f);

        messageText.text = "";
    }
}