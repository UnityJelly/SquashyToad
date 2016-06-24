using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameLoader : MonoBehaviour {

	// Use this for initialization
	public void LoadGame()
    {
        SceneManager.LoadScene("Main");
    }
}
