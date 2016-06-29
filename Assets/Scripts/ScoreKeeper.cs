using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

    public int score = 0;

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncrementScore(int amount)
    {

        score += amount;
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
    }
}
