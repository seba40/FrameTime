using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {
    public Image changer1;
    public Image changer2;
    public Sprite calendar;
    public Sprite clock;
    public Canvas clockPanel;
    public Canvas calendarPanel;
    public void ShowCalendar()
    {

        clockPanel.enabled = false;
        calendarPanel.enabled = true;

    }
    public void ShowClock()
    {
        clockPanel.enabled = true;
        calendarPanel.enabled = false;

    }

    void Start()
    {
        changer1.sprite = calendar;
        changer2.sprite = clock;
        calendarPanel.enabled = false;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

    }
	// Use this for initialization

}
