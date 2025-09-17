using UnityEngine;

public class EventsManager : MonoBehaviour
{
    public delegate void CameraTriggerEv();
    public static event CameraTriggerEv onCameraTriggerEvent;

    public delegate void SendScoreEnemyDeadEv(int score);
    public static event SendScoreEnemyDeadEv onSendScoreEnemyDeadEvent;

    public delegate void FinishedLevelEv(bool finished);
    public static event FinishedLevelEv onFinishedLevelEvent;

    public delegate void PlayerLifeUpdateEv(int health);
    public static event PlayerLifeUpdateEv onPlayerLifeUpdateEvent;

    public delegate void CoinUpdateEv();
    public static event CoinUpdateEv onCoinUpdateEvent;

    public delegate void KeyAchievedEv();
    public static event  KeyAchievedEv onKeyAchievedEvent;

    public static void CameraTriggerEvent()
    {
        if (onCameraTriggerEvent != null)
            onCameraTriggerEvent();
    }

    public static void SendScoreEnemyDeadEvent(int score)
    {
        if (onSendScoreEnemyDeadEvent != null)
            onSendScoreEnemyDeadEvent(score);
    }

    public static void FinishedLevelEvent(bool finished)
    {
        if (onFinishedLevelEvent != null)
            onFinishedLevelEvent(finished);
    }

    public static void PlayerLifeUpdateEvent(int health)
    {
        if (onPlayerLifeUpdateEvent != null)
            onPlayerLifeUpdateEvent(health);
    }

    public static void CoinUpdateEvent()
    {
        if (onCoinUpdateEvent != null)
            onCoinUpdateEvent();
    }

    public static void KeyAchievedEvent()
    {
        if (onKeyAchievedEvent != null)
            onKeyAchievedEvent();
    }
}
