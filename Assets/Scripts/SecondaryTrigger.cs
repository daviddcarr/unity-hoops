using UnityEngine;
using System.Collections;

public class SecondaryTrigger : MonoBehaviour {

    Collider expectedCollider;
    public int nextLevelDelay = 1;

    public void ExpectCollider(Collider collider)
    {
        expectedCollider = collider;
    }

    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider == expectedCollider)
        {
            StartCoroutine(loadSceneTask());
        }
    }

    IEnumerator loadSceneTask()
    {
        yield return new WaitForSeconds(nextLevelDelay);
        LevelManager levelManager = FindObjectOfType<LevelManager>();
        levelManager.LoadNextScene();
    }
}
