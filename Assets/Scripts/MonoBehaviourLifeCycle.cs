using UnityEngine;

public class MonoBehaviourLifeCycle : MonoBehaviour
{
    void Awake() => Debug.Log("Awake");

    void OnEnable() => Debug.Log("On Enable");

    void Start() => Debug.Log("Start");

    void FixedUpdate() => Debug.Log("FixedUpdate");

    void Update() => Debug.Log("Update");

    void LateUpdate() => Debug.Log("LateUpdate");

    void OnDisable() => Debug.Log("On Disable");

    void OnDestroy() => Debug.Log("On Destroy");
}
