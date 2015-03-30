using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	public float speed;

	void FixedUpdate()
	{
		float moveHorizongtal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizongtal,0,moveVertical);
		GetComponent<Rigidbody>().AddForce (movement * speed * Time.deltaTime);
	}
}
