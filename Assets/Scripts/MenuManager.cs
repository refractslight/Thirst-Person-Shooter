using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject credits;
    public GameObject backButton;
    public GameObject creditsButton;
    public GameObject startButton;
    public GameObject howToPlay;
    public GameObject howToButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BeginGame()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void Credits()
    {
        creditsButton.gameObject.SetActive(false);
        credits.gameObject.SetActive(true);
        backButton.gameObject.SetActive(true);
        startButton.gameObject.SetActive(false);
        howToButton.gameObject.SetActive(false);

    }

    public void Back()
    {
        creditsButton.gameObject.SetActive(true);
        credits.gameObject.SetActive(false);
        backButton.gameObject.SetActive(false);
        startButton.gameObject.SetActive(true);
        howToPlay.gameObject.SetActive(false);
        howToButton.gameObject.SetActive(true);

    }

    public void HowTo()
    {
        creditsButton.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);
        backButton.gameObject.SetActive(true);
        howToPlay.gameObject.SetActive(true);
        howToButton.gameObject.SetActive(false);
    }

}
