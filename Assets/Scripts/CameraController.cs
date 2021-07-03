using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public Transform carTransform;

	void FixedUpdate () {
		Vector3 newPosition = carTransform.position;
		newPosition.z = -10;
		transform.position = newPosition;
	}
}
