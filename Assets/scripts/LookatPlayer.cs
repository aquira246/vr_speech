using UnityEngine;
using System.Collections;

public class LookatPlayer : MonoBehaviour {

    public GameObject tracked;
    public GameObject trackedFloor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Transform target = trackedFloor.transform;
        Vector3 target = new Vector3(tracked.transform.position.x, trackedFloor.transform.position.y, tracked.transform.position.z);
        transform.LookAt(target);
	}
}
