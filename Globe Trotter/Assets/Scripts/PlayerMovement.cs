using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour {

	public float playerSpeed;
	public float jumpHeight;
	private Rigidbody rb;

    
    public bool onGround;

	void Start () {
		onGround = true;
		rb = GetComponent<Rigidbody>();
	}

    void Update(){

		if(onGround) {
			if (Input.GetButtonDown("Jump"))
			{
				rb.velocity = new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z);
				onGround = false;
			}
        }

    }

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Ground"))
		{
			onGround = true;
		}
	}
	
	void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * playerSpeed);
    }
}
