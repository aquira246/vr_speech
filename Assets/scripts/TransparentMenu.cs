using UnityEngine;
using System.Collections;

public class TransparentMenu : MonoBehaviour {
    public GameObject viewport;
    void UpdateTransparency()
    {
        Vector3 lookDir = viewport.transform.forward;
        Vector3 nor = this.transform.up;
        float transAmnt = Vector3.Dot(lookDir.normalized, -nor.normalized);
        Color cCol = GetComponent<Renderer>().material.color;
    
        GetComponent<Renderer>().material.color = new Color(cCol.r, cCol.g, cCol.b, Mathf.Clamp(transAmnt, 0, 1));
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        UpdateTransparency();
	}
}
