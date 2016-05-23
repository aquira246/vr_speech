using UnityEngine;
using System.Collections;

public class LightDimmer : MonoBehaviour {
    public bool dimmed;
    public float maxIntensity;
    public float dimSpeed = 0.01f;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    if(dimmed)
        {

            foreach(Light l in this.GetComponentsInChildren<Light>())
            {
                if(l.intensity > 0.001)
                {
                    l.intensity -= dimSpeed;
                }
            }
        }
        else
        {
            foreach (Light l in this.GetComponentsInChildren<Light>())
            {
                if (l.intensity < maxIntensity)
                {
                    l.intensity += dimSpeed;
                }
            }
        }
	}
}
