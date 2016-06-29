using UnityEngine;
using System.Collections;

public class PaceAnimationX : MonoBehaviour {

	public bool startByMovingRight = false;
	bool movingRight;
	public float range = 10.0f;
	float rightBound;
	float leftBound;
	Vector3 currentPosition;
	public Vector3 speed = new Vector3 (0.01f,0.0f,0.0f);

	// Use this for initialization
	void Start () {
		movingRight = startByMovingRight;
		currentPosition = transform.position;
		print (currentPosition);
		rightBound = currentPosition.x + (range / 2);
		leftBound = currentPosition.x - (range / 2); 
	}

	// Update is called once per frame
	void Update () {
		if (movingRight) {
			if (currentPosition.x < rightBound) {
				currentPosition = currentPosition + speed;
			} else {
				movingRight = false;
				currentPosition = currentPosition - speed;
			}
		} else {
			if (currentPosition.x > leftBound) {
				currentPosition = currentPosition - speed;
			} else {
				movingRight = true;
				currentPosition = currentPosition + speed;
			}
		}
		transform.position = currentPosition;
	}
}
