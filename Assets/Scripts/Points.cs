using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{


    public string scoreText;
    public TextMeshProUGUI number;
    //public TextMeshProUGUI final;
    public string pointsString;
    public int score = 0;
    // Start is called before the first frame update

    void Start()
    {
        
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

//Send points over to next scene
    void OnDisable(){
        PlayerPrefs.SetInt("score", score);
    }
    
}
