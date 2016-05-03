using UnityEngine;
using System.Collections;

public class LookatPlayer : MonoBehaviour {

    public GameObject tracked;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Transform target = tracked.transform;
        transform.LookAt(target);
	}
}
