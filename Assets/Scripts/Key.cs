using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();

        if (player != null)
        {
            player.key = true;
            EventsManager.KeyAchievedEvent();
            Destroy(gameObject);
        }
    }
}
