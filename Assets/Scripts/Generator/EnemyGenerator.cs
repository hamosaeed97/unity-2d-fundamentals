using System.Collections;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform startPosition;
    [SerializeField] private float delay;
    [SerializeField] private int numEnemies;

    private bool activated;

    private void Start() => activated = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ON TRIGGER ENTER 2D: " + collision.gameObject.tag);

        if (collision.gameObject.GetComponent<PlayerHealth>() != null && !activated)
        {
            //This is to only invoke to generate enemies once.
            activated = true;
            StartCoroutine("Generator");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("ON TRIGGER STAY 2D: " + collision.gameObject.tag);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("ON TRIGGER EXIT 2D: " + collision.gameObject.tag);
    }

    IEnumerator Generator()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            //The start position is a GO that we are only going to use for its component transform and its position attribute
            Instantiate(enemyPrefab, startPosition.position, Quaternion.identity);
            yield return new WaitForSeconds(delay);
        }
        //After all enemies have been created, the GO itself is deactivated.
        gameObject.SetActive(false);
    }

    public void StopGenerator() => StopCoroutine("Generator");
}
