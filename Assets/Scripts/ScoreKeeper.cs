using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

    public int attempts = 1;

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void IncrementAttempts(int amount)
    {

        attempts += amount;
        // AudioSource source = GetComponent<AudioSource>();
        // source.Play();
    }
}
