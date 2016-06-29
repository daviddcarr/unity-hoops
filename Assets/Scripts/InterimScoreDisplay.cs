using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InterimScoreDisplay : MonoBehaviour {

	ScoreAbsorber scoreAbsorber;
	Text text;

	// Use this for initialization
	void Start () {
		scoreAbsorber = FindObjectOfType<ScoreAbsorber> ();
		text = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		text.text = "SCORE: " + scoreAbsorber.score;
	}
}
