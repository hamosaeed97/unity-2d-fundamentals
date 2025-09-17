using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject countdown;
    [SerializeField] private Transform playerStartPosition;
    [SerializeField] private GameObject keyGenerator;

    private int totalScore;
    public GameObject initialBlock;

    private void OnEnable()
    {
        EventsManager.onCameraTriggerEvent += CameraTriggerEvent;
        EventsManager.onFinishedLevelEvent += FinishedLevelEvent;
    }

    private void OnDisable()
    {
        EventsManager.onCameraTriggerEvent -= CameraTriggerEvent;
        EventsManager.onFinishedLevelEvent -= FinishedLevelEvent;
    }

    void Awake()
    {
        //Restore application time
        Time.timeScale = 1;
        Instantiate(player, playerStartPosition.position, Quaternion.identity).SetActive(true);
        Instantiate(countdown, Vector3.zero, Quaternion.identity).SetActive(true);
        keyGenerator.SetActive(true);
    }

    private void FinishedLevelEvent(bool finished) => StopAllCoroutines();

    private void CameraTriggerEvent()
    {
        //The camera is set as GO son of player
        mainCamera.gameObject.transform.parent = GameObject.FindGameObjectWithTag("Player").transform;
        mainCamera.gameObject.transform.localPosition = new Vector3(0, 0, -10);

        //GO collider is deactivated
        initialBlock.SetActive(false);
    }
}
