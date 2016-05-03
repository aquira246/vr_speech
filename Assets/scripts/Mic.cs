using UnityEngine;
using System.Collections;

public class Mic : MonoBehaviour {

    public AudioClip c;
    public string MicName;
    //private SteamVR_Controller.Device device;
    //private SteamVR_TrackedObject trackedController;

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

    //void Awake()
    //{
    //    trackedController = GetComponent<SteamVR_TrackedObject>();
    //}

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.T)/* || device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger)*/)
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

    // setup the vive controller
    //void FixedUpdate()
    //{
    //    device = SteamVR_Controller.Input((int)trackedController.index);
    //}

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
