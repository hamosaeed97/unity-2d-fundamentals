using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text score;
    [SerializeField] private Text playerLivesText;
    [SerializeField] private GameObject endPanel;
    [SerializeField] private GameObject key;

    private int totalScore;

    private void OnEnable()
    {
        EventsManager.onPlayerLifeUpdateEvent += PlayerLifeUpdateEvent;
        EventsManager.onCoinUpdateEvent += CoinUpdateEvent;
        EventsManager.onKeyAchievedEvent += KeyAchievedEvent;
        EventsManager.onSendScoreEnemyDeadEvent += ScoreEnemyDeadEvent;
        EventsManager.onFinishedLevelEvent += FinishedLevelEvent;
    }

    private void OnDisable()
    {
        EventsManager.onPlayerLifeUpdateEvent -= PlayerLifeUpdateEvent;
        EventsManager.onCoinUpdateEvent += CoinUpdateEvent;
        EventsManager.onKeyAchievedEvent -= KeyAchievedEvent;
        EventsManager.onSendScoreEnemyDeadEvent -= ScoreEnemyDeadEvent;
        EventsManager.onFinishedLevelEvent -= FinishedLevelEvent;
    }

    void Start()
    {
        totalScore = 0;
        score.text = totalScore.ToString();
    }

    //Obtain it the Text component and it depends of finished results set a feedback message into UI
    private void FinishedLevelEvent(bool finished)
    {
        //Application paused
        Time.timeScale = 0;

        endPanel.SetActive(true);
        Text panelText = endPanel.transform.GetChild(0).GetComponent<Text>();

        if (finished)
        {
            panelText.text = "YOU WIN";
            panelText.color = Color.yellow;
        }
        else
        {
            panelText.text = "YOU DIED";
            panelText.color = Color.red;
        }
    }

    private void PlayerLifeUpdateEvent(int health)
    {
        playerLivesText.GetComponent<Text>().text = health.ToString();
    }

    private void CoinUpdateEvent()
    {
        totalScore++;
        score.text = totalScore.ToString();
    }

    private void ScoreEnemyDeadEvent(int score)
    {
        totalScore += score;
        this.score.text = totalScore.ToString();
    }

    private void KeyAchievedEvent() => key.SetActive(true);
}
