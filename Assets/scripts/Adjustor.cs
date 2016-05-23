using UnityEngine;
using System.Collections;
[RequireComponent(typeof(SteamVR_TrackedObject))]
public class Adjustor : MonoBehaviour {

    adjustable potentialAdjust;
    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;
    // Use this for initialization
    void Start () {
        potentialAdjust = null;
        trackedObj = GetComponent<SteamVR_TrackedObject>();

    }

    // Update is called once per frame
    void FixedUpdate () {
	    if(potentialAdjust != null)
        {
            device = SteamVR_Controller.Input((int)trackedObj.index);
            if (device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger))
            {
                potentialAdjust.onPullStart(transform.position);
            }
            else if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
            {
                potentialAdjust.onPullChanged(transform.position);
            }
            if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
            {
                potentialAdjust.onPullEnd(transform.position);
            }
        }
	}
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Adjustable")
        {
            Debug.Log("Can adjust");
            if(potentialAdjust != null)
            {
                potentialAdjust.onPullEnd(this.transform.position);
            }
            potentialAdjust = other.GetComponent<adjustable>();
        }

    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger exit");
        if (other.gameObject.GetComponent<adjustable>() != null)
        {
            other.GetComponent<adjustable>().onPullEnd(this.transform.position);
        }
        potentialAdjust = null;
    }
}
