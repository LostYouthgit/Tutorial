using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayBeh : MonoBehaviour {

	public float speed = 10f;
	private Rigidbody2D rb;
	

	// Use this for initialization
	void Start () {
	
		rb = GetComponent <Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {

			float moveX = Input.GetAxis("Horizontal");
			rb.MovePosition (rb.position + Vector2.right * moveX * speed * Time.deltaTime);
			
			if (Input.GetKeyDown (KeyCode.Space))
				Jump();
	}

	void FixedUpdate()
	{
		
				//rb.AddForce (transform.up * 3f, ForceMode2D.Impulse);
	}

	void Jump()
	{
		rb.AddForce (transform.up * 70f, ForceMode2D.Impulse);
	}

	void OnCollisionEnter2D (Collision2D touch)
	{
		if (touch.gameObject.tag == "Respawn")
			ReloadLvl();
		
	}

	void OnColliderEnter2D (Collider2D touch)
	{
		if (touch.gameObject.tag == "Finish")
			Exit();
	}

	void Exit ()
	{
		SceneManager.LoadScene("scene2");
	}

	void ReloadLvl ()
	{
		Application.LoadLevel (Application.loadedLevel);

	}


}
