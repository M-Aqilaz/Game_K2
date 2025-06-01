using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeMechanic : MonoBehaviour
{
    public Text clockText; // Assign in Inspector if using UI
    public float nightDuration = 420f; // 7 minutes = 420 seconds
    private float timer = 0f;
    private int currentHour = 21; // Start at 9 PM (21:00)
    private int totalGameMinutes = 0;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        totalGameMinutes = 0;
        currentHour = 21;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        // Calculate in-game minutes based on progress
        int newGameMinutes = Mathf.FloorToInt((timer / nightDuration) * 420); // 7 hours * 60 minutes

        if (newGameMinutes != totalGameMinutes)
        {
            totalGameMinutes = newGameMinutes;
            currentHour = 21 + (totalGameMinutes / 60);
            int minute = totalGameMinutes % 60;

            if (currentHour >= 24) currentHour -= 24; // wrap around if needed

            // Optional UI update
            if (clockText != null)
                clockText.text = $"{currentHour:00}:{minute:00}";
        }

        // End of night
        if (timer >= nightDuration)
        {
            NextDay();
        }
    }
    
    void NextDay()
    {
        // Transition to next day logic
        Debug.Log("Night complete. Starting next day...");
        timer = 0f;
        totalGameMinutes = 0;
        currentHour = 21;
        // You can trigger a cutscene, reset animatronics, load new data, etc.
    }
}
