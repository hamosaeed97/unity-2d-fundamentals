using NUnit.Framework;
using UnityEngine;

public class KeyGenerator : MonoBehaviour
{
    [SerializeField] private GameObject key;
    [SerializeField] private Transform[] positions;

    void Start()
    {
        //Selects a random position from among all those in the transforms array
        Vector3 randomPosition = positions[Random.Range(0, positions.Length)].position;

        Instantiate(key, randomPosition, Quaternion.identity);
        Destroy(gameObject, 1);
    }
}
