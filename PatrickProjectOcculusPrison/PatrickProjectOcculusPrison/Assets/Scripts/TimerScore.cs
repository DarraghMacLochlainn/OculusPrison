using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class TimerScore : MonoBehaviour
{
    public Text display;

    private float timer;

    // Use this for initialization
    void Start(){
        timer = PlayerPrefs.GetFloat("timer");
        if (Application.loadedLevelName == "Tutorial")
        {
            timer = 0;
            PlayerPrefs.SetFloat("timer", timer);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.loadedLevelName != "EndScreen")
        {
            //every second, add 1 to timer
            timer += Time.deltaTime;
            PlayerPrefs.SetFloat("timer", timer);
        }
        int timer1 = (int) timer / 60;
        float timer2 = timer - timer1 * 60;
        display.text = ((int) timer1).ToString() + "m " + ((int) timer2).ToString() + "s";
    }
}