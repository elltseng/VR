using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
	private bool spawned = false;
	private float decay;

	public Object spawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	/*void Update () {
		reset();
		if (OVRInput.Get (OVRInput.Touch.Two) && !spawned) {
			decay = 1f;
			spawned = true;
			Debug.Log ("Pressed");
			Instantiate(spawn, transform.position, transform.rotation);
		}
	}*/

	public void spawnObject()
	{
		//reset();
		if (!spawned) {
			decay = 1f;
			spawned = true;
			Debug.Log ("Pressed");
			Instantiate (spawn, transform.position, transform.rotation);
		}
	}


	public void reset()
	{
		if (spawn && decay > 0)
			decay -= Time.deltaTime;
		if (decay < 0) {
			decay = 0;
			spawned = false;
		}
	}




}
