using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerHealth>() != null)
        {
            EventsManager.CoinUpdateEvent();
            Destroy(gameObject, 0.15f);
        }
    }
}
