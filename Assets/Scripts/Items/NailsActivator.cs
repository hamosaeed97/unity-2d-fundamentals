using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NailsActivator : MonoBehaviour
{
    [SerializeField] private List<GameObject> nails;
    [SerializeField] private float delayNails;
    [SerializeField] private bool activated;

    private void Start()
    {
        Activate(activated);
        StartCoroutine("NailsLoop");
    }

    IEnumerator NailsLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(delayNails);
            activated = !activated;
            Activate(activated);
        }
    }

    private void Activate(bool activated)
    {
        foreach(GameObject nail in nails)
        {
            nail.SetActive(activated);
        }
    }
}
