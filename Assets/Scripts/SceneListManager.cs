using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneListManager : MonoBehaviour
{
    public void SceneList(string scene) => SceneManager.LoadScene(scene);

    public void Exit() => Application.Quit();
}
