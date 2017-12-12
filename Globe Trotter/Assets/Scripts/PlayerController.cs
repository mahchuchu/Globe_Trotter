using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	private Vector3 position;

	public LayerMask groundLayer;
	public float jumpHeight;
	private float raySize = 1.0f;
	public bool isGrounded;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Update ()
	{
		position = transform.position;
		isGrounded = IsGrounded ();
		if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
			rb.AddForce (Vector3.up * jumpHeight);
		}
	}
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}
	private bool IsGrounded(){
		return Physics.Raycast(position,Vector3.down,raySize,groundLayer);
	}

}
