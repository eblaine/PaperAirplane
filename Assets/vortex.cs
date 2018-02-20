using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vortex : MonoBehaviour {
	private boat boatScript;
	public float forceMultiplier = 100f;
	// Use this for initialization
	void Start () {
		boatScript = GameObject.Find ("Boat").GetComponent<boat> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentPosition = boatScript.transform.position;
		Vector3 newForce = new Vector3(-currentPosition.x, 0f, -currentPosition.z);
		boatScript.waterForce = forceMultiplier * newForce;
//		boat.waterForce = new Vector3(100f, 100f, 100f);
	}
}
