using UnityEngine;
using System.Collections;

public class PaceAnimationZ : MonoBehaviour {

	public bool startByMovingForward = false;
	bool movingForward;
	public float range = 10.0f;
	float forwardBound;
	float backBound;
	Vector3 currentPosition;
	public Vector3 speed = new Vector3 (0.0f,0.0f,0.01f);

	// Use this for initialization
	void Start () {
		movingForward = startByMovingForward;
		currentPosition = transform.position;
		forwardBound = currentPosition.z + (range / 2);
		backBound = currentPosition.z - (range / 2); 
	}

	// Update is called once per frame
	void Update () {
		if (movingForward) {
			if (currentPosition.z < forwardBound) {
				currentPosition = currentPosition + speed;
			} else {
				movingForward = false;
				currentPosition = currentPosition - speed;
			}
		} else {
			if (currentPosition.z > backBound) {
				currentPosition = currentPosition - speed;
			} else {
				movingForward = true;
				currentPosition = currentPosition + speed;
			}
		}
		transform.position = currentPosition;
	}
}
