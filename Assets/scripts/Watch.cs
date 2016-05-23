using UnityEngine;
using System.Collections;

public class Watch : MonoBehaviour {
    public float StartTime = 0;
    public float EndTime = 0;
    public bool timerOn = false;
    // Use this for initialization
	void Start () {
        StartTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
	    if (timerOn)
        {
            EndTime = Time.time;
            UpdateTime();
        }
	}

    void UpdateTime()
    {
        int DiffTime = Mathf.RoundToInt(EndTime - StartTime);
        string minutes = Mathf.Floor(DiffTime / 60).ToString("00");
        string seconds = Mathf.Floor(DiffTime % 60).ToString("00");
        string TimeText = minutes + ":" + seconds;
        GetComponent<TextMesh>().text = TimeText;
    }

    void StartTimer()
    {
        StartTime = Time.time;
        EndTime = StartTime;
        UpdateTime();
    }

    void StopTimer()
    {
        timerOn = false;
        UpdateTime();
    }

    void PauseTimer()
    {
        timerOn = !timerOn;
        UpdateTime();
    }
}
