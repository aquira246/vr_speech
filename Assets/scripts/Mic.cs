using UnityEngine;
using System.Collections;

public class Mic : MonoBehaviour {

    public string MicName = "";
    //private SteamVR_Controller.Device device;
    //private SteamVR_TrackedObject trackedController;
    public bool recording = true;
    AudioSource aud;

    void Start()
    {
        if (MicName != "")
        {
            // we are using the MicName given
        }
        else if (Microphone.devices.Length > 0)
        {
            MicName = Microphone.devices[0];
        }
        else
        {
            MicName = "Microphone";
        }
        AudioSource aud = GetComponent<AudioSource>();
        aud.clip = Microphone.Start(null, true, 10, 44100);
        aud.loop = true;

        while (!(Microphone.GetPosition(null) > 0))
        { }
        aud.Play();
    }

    //   void Start()
    //   {
    //       if (MicName != "")
    //       {
    //           // we are using the MicName given
    //           StartRecording();
    //       }
    //        else if (Microphone.devices.Length > 0)
    //       {
    //           MicName = Microphone.devices[0];
    //           StartRecording();
    //       }
    //       else
    //       {
    //           MicName = "Microphone";
    //       }
    //   }

    //   //void Awake()
    //   //{
    //   //    trackedController = GetComponent<SteamVR_TrackedObject>();
    //   //}

    //// Update is called once per frame
    void Update()
    {
        
    }

    //   // setup the vive controller
    //   //void FixedUpdate()
    //   //{
    //   //    device = SteamVR_Controller.Input((int)trackedController.index);
    //   //}

    void StopRecording()
    {
        Microphone.End(MicName);
        GetComponent<AudioSource>().Stop();
    }

    void StartRecording()
    {
       
        
    }
}
