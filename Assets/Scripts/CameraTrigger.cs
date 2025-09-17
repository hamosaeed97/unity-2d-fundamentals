using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerHealth>() != null)
        {
            //An event is issued to activate the camera.
            EventsManager.CameraTriggerEvent();
            Destroy(gameObject);
        }
    }
}
