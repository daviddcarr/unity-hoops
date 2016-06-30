using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    ScoreKeeper scoreKeeper;
    Text text;

    // Use this for initialization
    void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "ATTEMPTS: " + scoreKeeper.attempts;
    }
}
