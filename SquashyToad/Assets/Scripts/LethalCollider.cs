using UnityEngine;
using System.Collections;

public class LethalCollider : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter (Collision collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        if (player != null)
        {
            GameState state = GameObject.FindObjectOfType<GameState>();
            state.IsGameOver = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
