using UnityEngine;
using System.Collections;

public class Mic : MonoBehaviour {

    public AudioClip c;
    public string MicName;

    void Start()
    {
        if (Microphone.devices.Length > 0)
        {
            MicName = Microphone.devices[0];
        }
        else
        {
            MicName = "Microphone";
        }
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (Microphone.IsRecording(MicName))
            {
                StopRecording();
            }
            else
            {
                StartRecording();
            }
        }
	}

    void StopRecording()
    {
        Microphone.End(MicName);
        GetComponent<AudioSource>().Stop();
    }

    void StartRecording()
    {
        c = Microphone.Start(MicName, true, 300, 48000); // the last one is frequency, that changes with device
        while (!(Microphone.GetPosition(MicName) > 0)) 
        {
            GetComponent<AudioSource>().PlayOneShot(c);
        }
    }
}
