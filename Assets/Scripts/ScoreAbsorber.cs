using UnityEngine;
using System.Collections;

public class ScoreAbsorber : MonoBehaviour {

	public int attempts;

	// Use this for initialization
	void Start () {
		ScoreKeeper oldKeeper = FindObjectOfType<ScoreKeeper> ();
		attempts = 1;
		if (oldKeeper) {
			attempts = oldKeeper.attempts;
			Destroy (oldKeeper.gameObject);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
