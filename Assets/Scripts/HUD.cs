using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public GameObject HUDObj;
    public GameObject HUDObj2;
    public GameObject helpText;
    public bool isShowing;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            isShowing = !isShowing;
        }

        if (isShowing)
        {
            HUDObj.SetActive(true);
            HUDObj2.SetActive(true);
            helpText.SetActive(false);
        }
        else{
            helpText.SetActive(true);
            HUDObj.SetActive(false);
            HUDObj2.SetActive(false);
        }
    }
}
