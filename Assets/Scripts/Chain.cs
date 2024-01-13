using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour
{
	public static bool IsFired;
	public float speed = 1.5f;	
	public Transform player;
	
    void Start()
    {
	    IsFired = false;     
    }

  
    void Update()
	{
		if(Input.GetButtonDown("Fire1"))
		{
			IsFired = true;
		}
    	
		if(IsFired)
	    {
	    	transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * speed;
	    }
	    else
	    {
	    	transform.position = player.position;
	    	transform.localScale = new Vector3(1,0,1);
	    }
    }
}
