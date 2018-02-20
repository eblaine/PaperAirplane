using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boat : MonoBehaviour {

	public float turnSpeed = 5000f;
	public float accelSpeed = 5000f;
	public Vector3 waterForce;

	private Rigidbody rbody;

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody>();
		waterForce = new Vector3 (0f, 0f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
//		float v = 1f;

		rbody.AddTorque (0f, h * turnSpeed * Time.deltaTime, 0f);
		rbody.AddForce (transform.forward * v * accelSpeed * Time.deltaTime);
		rbody.AddForce (waterForce * Time.deltaTime);

	}
}
