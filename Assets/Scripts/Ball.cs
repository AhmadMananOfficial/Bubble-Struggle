using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public Vector2 startForce;
	public GameObject nextBall;
	
	Rigidbody2D rb;	
    // Start is called before the first frame update
    void Start()
    {
	    rb = GetComponent<Rigidbody2D>();
	    rb.AddForce(startForce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
	public void Split()
    {
	    if (nextBall != null)
	    {
		    GameObject ball1 = Instantiate(nextBall, rb.position + Vector2.right / 4f, Quaternion.identity);
		    GameObject ball2 = Instantiate(nextBall, rb.position + Vector2.left / 4f, Quaternion.identity);

		    ball1.GetComponent<Ball>().startForce = new Vector2(2f, 5f);
		    ball2.GetComponent<Ball>().startForce = new Vector2(-2f, 5f);
	    }

	    Destroy(gameObject);
    }
}
