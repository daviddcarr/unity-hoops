using UnityEngine;
using System.Collections;

public class PaceAnimationY : MonoBehaviour {

	public bool startByMovingUp = false;
	bool movingUp;
	public float range = 10.0f;
	float topBound;
	float bottomBound;
	Vector3 currentPosition;
	public Vector3 speed = new Vector3 (0.0f,0.01f,0.0f);

	// Use this for initialization
	void Start () {
		movingUp = startByMovingUp;
		currentPosition = transform.position;
		topBound = currentPosition.y + (range / 2);
		bottomBound = currentPosition.y - (range / 2); 
	}

	// Update is called once per frame
	void Update () {
		if (movingUp) {
			if (currentPosition.y < topBound) {
				currentPosition = currentPosition + speed;
			} else {
				movingUp = false;
				currentPosition = currentPosition - speed;
			}
		} else {
			if (currentPosition.y > bottomBound) {
				currentPosition = currentPosition - speed;
			} else {
				movingUp = true;
				currentPosition = currentPosition + speed;
			}
		}
		transform.position = currentPosition;
	}
}
