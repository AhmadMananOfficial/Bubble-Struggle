using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public float speed = 5f; // Adjust the speed as needed
	private Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		// Get input for horizontal movement
		float horizontalInput = Input.GetAxis("Horizontal");

		// Move the player
		Vector2 movement = new Vector2(horizontalInput, 0);
		rb.velocity = new Vector2(movement.x * speed, rb.velocity.y);
	}
}
