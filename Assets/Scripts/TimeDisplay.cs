using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {

    LevelManager levelManager;
    Text text;

    // Use this for initialization
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "TIME LEFT: " + levelManager.timeUntilNextLevel;
    }
}
