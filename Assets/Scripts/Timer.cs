using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public float timeLeft;

    public string timeString;
    public TextMeshProUGUI timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        int timeRound = (int)timeLeft;
        timeString = timeRound.ToString();
        timerText.SetText(timeString);
        if (timeString == "0")
        {
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }
    }
}
