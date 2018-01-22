using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Batery : MonoBehaviour {
    public Slider bLevel;
    public GameObject bSlider;
    public Image bImage;
    public BatteryStatus bStatus;
    public Sprite bImage_Charging;
    public Sprite bImage_Discharging;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        bStatus = SystemInfo.batteryStatus;
        if (bStatus== BatteryStatus.Charging)
        {
            bImage.sprite = bImage_Charging;
            bSlider.SetActive(false);
        }
        if (bStatus == BatteryStatus.Discharging)
        {
            bImage.sprite = bImage_Discharging;
            bSlider.SetActive(true);

            bLevel.value = SystemInfo.batteryLevel;

        }



    }
}
