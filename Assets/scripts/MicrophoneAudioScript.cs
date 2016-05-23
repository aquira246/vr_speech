using UnityEngine;
using System.Collections;

public class MicrophoneAudioScript : MonoBehaviour {
    public AudioSource sourceEffect;
    public Transform sourceTransform;
    public Transform recieverTransform;
    public float expectedDist = 1.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float volume = 1.0f;
        volume *= (1 - Mathf.Abs((sourceTransform.position - recieverTransform.position).magnitude - expectedDist));
        volume *= Vector3.Dot((recieverTransform.position - sourceTransform.position).normalized, sourceTransform.forward.normalized);
        sourceEffect.volume = Mathf.Clamp(volume, 0, 1);
        Debug.Log("Volume: " + volume.ToString());
	}
}
