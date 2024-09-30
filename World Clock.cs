using System;
using UnityEngine;

public class WorldClock : UnityEngine.MonoBehaviour
{

    public GameObject clockPrefab;

    public int timeZoneOffset = 0;

    Vector3 nypos = new Vector3(-7, 7, 0);
    Vector3 londonpos = new Vector3(7, 7, 0);
    Vector3 tokyopos = new Vector3(-7, -7, 0);
    Vector3 sydneypos = new Vector3(7, -7, 0);

    void Start()
    {
        // Instantiate the New York clock
        GameObject newYorkClock = Instantiate(clockPrefab, nypos, Quaternion.identity);
        Clock newYorkClockScript = newYorkClock.GetComponent<Clock>();
        if (newYorkClockScript != null)
        {
            newYorkClockScript.timeZoneOffset = 0; // New York is UTC-4 (adjust for DST if necessary)
        }
        GameObject londonClock = Instantiate(clockPrefab, londonpos, Quaternion.identity);
        Clock londonClockScript = londonClock.GetComponent<Clock>();
        if (londonClockScript != null)
        {
            londonClockScript.timeZoneOffset = 5; // New York is UTC-4 (adjust for DST if necessary)
        }
        GameObject tokyoClock = Instantiate(clockPrefab, tokyopos, Quaternion.identity);
        Clock tokyoClockScript = tokyoClock.GetComponent<Clock>();
        if (tokyoClockScript != null)
        {
            tokyoClockScript.timeZoneOffset = 13; // New York is UTC-4 (adjust for DST if necessary)
        }
        GameObject sydneyClock = Instantiate(clockPrefab, sydneypos, Quaternion.identity);
        Clock sydneyClockScript = sydneyClock.GetComponent<Clock>();
        if (sydneyClockScript != null)
        {
            sydneyClockScript.timeZoneOffset = 14; // New York is UTC-4 (adjust for DST if necessary)
        }
    }
    void updateClock()
    {
        DateTime.UtcNow.AddHours(timeZoneOffset);
    }
    void Update()
    {
        updateClock();
    }
}
