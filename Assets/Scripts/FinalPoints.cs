using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FinalPoints : MonoBehaviour
{

    public int score;
    public string scoreText;
    public TextMeshProUGUI finalScore;


    void OnEnable()
    {

        score = PlayerPrefs.GetInt("score");
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText = score.ToString();
        finalScore.SetText(scoreText);

    }

    // Update is called once per frame
    void Update()
    {

    }




}
