using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollision (Collision2D touch)
	{
		if (touch.gameObject.tag == "Respawn")
			ReloadLvl();
	}

	void ReloadLvl ()
	{
		Application.LoadLevel (Application.loadedLevel);

	}

}
