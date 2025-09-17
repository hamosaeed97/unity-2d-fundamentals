using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CountDownManager : MonoBehaviour
{
    private int currentMinutes;
    public GameObject CounterText;
    public int maxTime;
    public float delay;
    private Text time;

    void Start()
    {
        time = GameObject.FindGameObjectWithTag("Time").GetComponent<Text>();
        currentMinutes = maxTime;
        StartCoroutine("CountDownCoroutine");
    }

    //Corrutine that counts down by waiting for delay and decrementing the counter and assigning it to the UI.
    IEnumerator CountDownCoroutine()
    {
        while (currentMinutes > 0)
        {
            yield return new WaitForSeconds(delay);
            currentMinutes--;
            time.text = currentMinutes.ToString();
        }
    }
}