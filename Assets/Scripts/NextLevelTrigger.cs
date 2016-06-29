using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class NextLevelTrigger : MonoBehaviour
{

    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;

    // Use this for initialization
    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        device = SteamVR_Controller.Input((int)trackedObj.index);
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            print("Trigger Pressed");
            LevelManager levelManager = FindObjectOfType<LevelManager>();
            levelManager.LoadNextScene();
        }
    }
}
