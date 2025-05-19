using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    private float startTime;
    private float endTime;
    private bool isRunning = true;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (isRunning)
        {
            endTime = Time.time;
        }
    }

    public void StopTimer()
    {
        isRunning = false;
    }

    public float GetElapsedTime()
    {
        return endTime - startTime;
    }
}
