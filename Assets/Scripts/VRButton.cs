using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRButton : MonoBehaviour {

	public Image Next;
	public Color NormalColor;
	public Color HighlightColor;

	// Use this for initialization
	void Start () {
		
	}

	public void OnGazeEnter() 
	{
		Next.color = HighlightColor;
	}

	public void OnGazeExit()
	{
		Next.color = NormalColor;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(OVRInput.Get(OVRInput.Button.One))
		{
			Debug.Log("works");
		}
		
	}

	

	
}
