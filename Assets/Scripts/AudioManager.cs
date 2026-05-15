using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource audioSource;

    public AudioClip pickupSound;
    public AudioClip deliverySound;

    private void Awake()
    {
        instance = this;
    }

    public void PlayPickupSound()
    {
        audioSource.PlayOneShot(pickupSound);
    }

    public void PlayDeliverySound()
    {
        audioSource.PlayOneShot(deliverySound);
    }
}