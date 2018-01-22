using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Date : MonoBehaviour
{

    public Text text;

    string DayOfWeek;
    string Day;
    string month;
    string year;
    void mn()
    {
        if (DateTime.Now.Month == 1)
        {
            month = "January";
        }
        if (DateTime.Now.Month == 2)
        {
            month = "February";
        }
        if (DateTime.Now.Month == 3)
        {
            month = "March";
        }
        if (DateTime.Now.Month == 4)
        {
            month = "April";
        }
        if (DateTime.Now.Month == 5)
        {
            month = "May";
        }
            if (DateTime.Now.Month == 6)
            {
                month = "June";
            }
            if (DateTime.Now.Month == 7)
            {
                month = "July";
            }
            if (DateTime.Now.Month == 8)
            {
                month = "August";
            }
            if (DateTime.Now.Month == 9)
            {
                month = "September";
            }
            if (DateTime.Now.Month == 10)
            {
                month = "October";
            }
            if (DateTime.Now.Month == 11)
            {
                month = "November";
            }
            if (DateTime.Now.Month == 12)
            {
                month = "December";
            }
        }
    
    // Use this for initialization
    void Start()
    {

    }
   
    // Update is called once per frame
    void Update()
    {
        DayOfWeek = DateTime.Now.DayOfWeek.ToString();
        mn();
        if (DateTime.Now.Day <= 9)
        {
            Day = "0"+DateTime.Now.Day.ToString();
        }
        else
            Day = DateTime.Now.Day.ToString();

        year = DateTime.Now.Year.ToString();

         text.text = DayOfWeek+", "+Day+" "+month+" "+year;

    }
}
