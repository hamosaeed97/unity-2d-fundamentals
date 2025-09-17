using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    [SerializeField] Sprite open;

    private void Start() => BoxCollider2DEnabled(false);

    private void OnTriggerEnter2D(Collider2D collision) => SceneManager.LoadScene("Menu");

    private void BoxCollider2DEnabled(bool enabled) => GetComponent<BoxCollider2D>().enabled = enabled;

    public void DoorEnabled()
    {
        BoxCollider2DEnabled(true);
        GetComponentInChildren<SpriteRenderer>().sprite = open;
    }
}