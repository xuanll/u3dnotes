using UnityEngine;
using System.Collections;

public class ThirdPersaonCam : MonoBehaviour {

	//follow aim
	public Transform follow;

	//follow distance
	public float distanceAway;

	//follow distance up
	public float distanceUp;

	//filter speed
	public float smooth;

	//speed of cam
	private Vector3 targetPosition;

	//always for camera use
	void LateUpdate () {
	
		targetPosition = follow.position + Vector3.up * distanceUp - follow.forward * distanceAway;

		transform.position = Vector3.Lerp (transform.position, targetPosition, Time.deltaTime * smooth);

		transform.LookAt (follow);
	}
}
