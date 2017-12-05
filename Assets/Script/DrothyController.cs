using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrothyController : MonoBehaviour 
{
	private Animator anim;
	private bool walking;

	[SerializeField]
	private float threasholdMoveSpeed = 1f;
	private Vector3 prevPosition;

	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator>();
		prevPosition = anim.bodyPosition;
		walking = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		var diff = (prevPosition - anim.bodyPosition).magnitude;

		//Debug.Log( diff );

		walking = diff >= threasholdMoveSpeed;

		if( walking != anim.GetBool("Walking") )
		{
			anim.SetBool("Walking", walking);
		}

		prevPosition = anim.bodyPosition;
	}
}
