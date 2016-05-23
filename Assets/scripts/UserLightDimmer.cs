using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UserLightDimmer : MonoBehaviour {
    bool toggle;
    public List<LightDimmer> dimLights = new List<LightDimmer>();
    public List<LightDimmer> brightLights = new List<LightDimmer>();

    // Use this for initialization
    void Start () {
	
	}

    public void ToggleLights()
    {
        toggle = !toggle;
        for (int i = 0; i < dimLights.Count; i++)
        {
            dimLights[i].dimmed = toggle;
        }
        for (int i = 0; i < brightLights.Count; i++)
        {
            brightLights[i].dimmed = !toggle;
        }
    }
	// Update is called once per frame
	void Update () {
        
	
	}
}
