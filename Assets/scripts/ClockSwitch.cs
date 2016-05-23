using UnityEngine;
using System.Collections;

public class ClockSwitch : MonoBehaviour {
    private bool onStart = true;
    private int toRotate = 0;
	// Use this for initialization
	void Start () {
        onStart = true;
        //GameObject.Find("StartSide").SetActive(onStart);
        //GameObject.Find("TimeSide").SetActive(!onStart);
	}

    public void Switch() {
        if (toRotate == 0)
        {
            if (onStart)
            {
                GameObject.FindGameObjectWithTag("Watch").GetComponent<Watch>().StartTimer();
            }
            else
            {
                GameObject.FindGameObjectWithTag("Watch").GetComponent<Watch>().StopTimer();
            }
            onStart = !onStart;
            toRotate = 180;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (toRotate > 0)
        {
            //if (toRotate == 135)
            //{
            //    GameObject.Find("StartSide").SetActive(true);
            //    GameObject.Find("TimeSide").SetActive(true);
            //}

            //if (toRotate == 45)
            //{
            //    GameObject.Find("StartSide").SetActive(onStart);
            //    GameObject.Find("TimeSide").SetActive(!onStart);
            //}

            //if (toRotate == 5)
            //{
            //    GameObject.Find("StartSide").SetActive(onStart);
            //    GameObject.Find("TimeSide").SetActive(!onStart);
            //}

            toRotate -= 5;

            // rotate the clock
            transform.Rotate(new Vector3(1, 0, 0), -5);
        }
	}
}
