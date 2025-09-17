using UnityEngine;

public class Lock : MonoBehaviour
{
    //Instead of using events, I add the game object and then access its component to invoke functions.
    [SerializeField] private GameObject door;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();

        if (player != null && player.key == true)
        {
            door.GetComponent<Door>().DoorEnabled();
            Destroy(gameObject, 0.5f);
        }
    }
}
