using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainCollision : MonoBehaviour
{
	
	protected void OnTriggerEnter2D(Collider2D other)
	{
		Chain.IsFired = false;

		if (other.tag == "Ball")
		{
			other.GetComponent<Ball>().Split();
		}	
	}
}
