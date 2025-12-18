using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int sceneIndex;
    void Start()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
