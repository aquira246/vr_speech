using UnityEngine;
using System.Collections;

public class adjustable : MonoBehaviour {
    private Vector3 startPoint;
    private Vector3 startScale;
  // Use this for initialization
	void Start () {
        startScale = transform.localScale;
  }
	
	// Update is called once per frame
	void Update () {
	    
	}
    public void onPullStart(Vector3 pullStart)
    {
        Debug.Log("Pull start");
        startPoint = pullStart;
    }
    public void onPullChanged(Vector3 pulledPosition)
    {
        float yDiff = pulledPosition.y - startPoint.y;

        Debug.Log("Pull change: " + new Vector3(startScale.x, startScale.y, startScale.z + (yDiff * startScale.z)).ToString());
        //Scale by yDiff
        transform.localScale = new Vector3(startScale.x, startScale.y, startScale.z + (yDiff * startScale.z));
    }
    public void onPullEnd(Vector3 pullEnd)
    {
        //Nothing for now
    }
    


}
