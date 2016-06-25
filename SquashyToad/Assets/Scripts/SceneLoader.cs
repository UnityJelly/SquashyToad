using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public float loadLevelAfterTime = 0;

	// Use this for initialization
	void Start () {
        if (loadLevelAfterTime > 0)
        {
            Invoke("LoadNextLevel", loadLevelAfterTime);
        }
	}

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
