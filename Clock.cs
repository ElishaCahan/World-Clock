using System;
using UnityEngine;

public class Clock : UnityEngine.MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    //public Clock clock = new Clock();
    //public Clock clockLondon = new Clock();
    //public Clock clockTokyo = new Clock();
    //public Clock clockSydney = new Clock();

    public int timeZoneOffset;
    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * ((float)time.TotalHours + timeZoneOffset));
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);
    }
}
