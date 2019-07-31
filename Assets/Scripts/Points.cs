using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{

    public int score;
    public string scoreText;
    public TextMeshProUGUI number;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        TextMeshProUGUI number = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddPoint()
    {
        score ++;
        scoreText = score.ToString();
        number.SetText(scoreText);
        Debug.Log(score);
    }

    
}
