using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishedGenerator : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerHealth>() != null)
            GetComponentInParent<EnemyGenerator>().StopGenerator();
    }
}
