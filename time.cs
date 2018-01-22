using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class time : MonoBehaviour {

    public Text text;
    string hour;
    string minute;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (DateTime.Now.Hour <= 9)
        {
            hour = "0" + DateTime.Now.Hour.ToString();
        }
        else
            hour =  DateTime.Now.Hour.ToString();
        if (DateTime.Now.Minute <= 9)
            {
                minute = "0" + DateTime.Now.Minute.ToString();
            }
        else
            minute = DateTime.Now.Minute.ToString();

        text.text = hour+":"+ minute;
	}
}
