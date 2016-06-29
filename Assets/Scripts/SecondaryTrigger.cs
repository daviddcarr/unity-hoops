using UnityEngine;
using System.Collections;

public class SecondaryTrigger : MonoBehaviour {

    Collider expectedCollider;
    public int scorePerHoop = 1;

    public void ExpectCollider(Collider collider)
    {
        expectedCollider = collider;
    }

    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider == expectedCollider)
        {
            ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
            scoreKeeper.IncrementScore(scorePerHoop);
        }
    }
}
