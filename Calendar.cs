using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Calendar : MonoBehaviour {
    Text[] days;
    public Text day;
    public GameObject parent;
    DateTime time;
    public Text currentYearAndMonth;
    DateTime currentTime;
    public GridLayoutGroup currentDayKnob;
    public Image selection;
    Image[] selections;
    public Sprite knob;
    int FirstDay()
    {
        DateTime temp = new DateTime(time.Year, time.Month, 1);
        if (temp.DayOfWeek == 0)
            return 7;
        return (int)temp.DayOfWeek;
    }

    public void NextMonth()
    {
        time=time.AddMonths(1);
        for (int i = 1; i <= 42; i++)
        {
            if (i < FirstDay())
                days[i].text = "";
            else
                if ((i - (FirstDay() - 1)) <= DateTime.DaysInMonth(time.Year, time.Month))
                days[i].text = (i - (FirstDay() - 1)).ToString();
            else
                days[i].text = "";
            if (currentTime.Month == time.Month && currentTime.Year == time.Year)
            {
                if (currentTime.Day == (i - (FirstDay() - 1)))
                {
                    days[i].color = Color.black;

                    selections[i].sprite = knob;
                    selections[i].color = Color.white;
                }
            }
            else
            {
                days[i].color = Color.white;

                selections[i].sprite = null;
                selections[i].color = Color.black;
            }



        }

    }
    public void PreviousMonth()
    {
        

        time=time.AddMonths(-1);
        for (int i = 1; i <= 42; i++)
        {
            if (i < FirstDay())
                days[i].text = "";
            else
                if ((i - (FirstDay() - 1)) <= DateTime.DaysInMonth(time.Year, time.Month))
                days[i].text = (i - (FirstDay() - 1)).ToString();
            else
                days[i].text = "";
            if (currentTime.Month == time.Month && currentTime.Year == time.Year)
            {
                if (currentTime.Day == (i - (FirstDay() - 1)))
                {
                    days[i].color = Color.black;

                    selections[i].sprite = knob;
                    selections[i].color = Color.white;
                }
            }
            else
            {
                days[i].color = Color.white;

                selections[i].sprite = null;
                selections[i].color = Color.black;
            }



        }

    }
	// Use this for initialization
	void Start () {
        time = DateTime.Now;
        currentTime = DateTime.Now;
        days = new Text[43];
        selections = new Image[43];
        selections[1] = selection;
        days[1] = day;
        for (int i =2;i<=42;i++)
        {
            days[i]=Instantiate(day,parent.transform);
            selections[i] = Instantiate(selection, currentDayKnob.transform);
        }

        for (int i = 1; i <= 42; i++)
        {
            if (i < FirstDay())
                days[i].text = "";
            else
                if ((i - (FirstDay() - 1))<= DateTime.DaysInMonth(time.Year, time.Month))
                    days[i].text = (i - (FirstDay()-1)).ToString();
                else
                    days[i].text = "";
            if (currentTime.Month == time.Month && currentTime.Year == time.Year)
            {
                if (currentTime.Day == (i - (FirstDay() - 1)))
                {
                    days[i].color = Color.black;
                    
                    selections[i].sprite = knob;
                    selections[i].color = Color.white;
                }
            }

        }

    } 

	
	// Update is called once per frame
	void Update () {
        currentYearAndMonth.text = time.ToString("MMMM") +" "+ time.Year.ToString();
    }
}
