using System.Collections;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    [SerializeField] private float fallTime;
    [SerializeField] private Sprite fallSprite;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerHealth>() != null)
            StartCoroutine("PlatformDown");
    }

    IEnumerator PlatformDown()
    {
        GameObject parent = gameObject.transform.parent.gameObject;
        parent.GetComponent<SpriteRenderer>().sprite = fallSprite;
        yield return new WaitForSeconds(fallTime);
        parent.GetComponent<BoxCollider2D>().isTrigger = true;
        parent.GetComponent<Rigidbody2D>().gravityScale = 1f;
        Destroy(parent, 3f);
    }
}
