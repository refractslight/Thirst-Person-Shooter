using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{

    public Shoot shooter;
    SpriteRenderer sodaSprite;
    public float depth = 10.0f;
    
    private float yMin = 5.0f;
    private float yMax = 1.95f;
    private float yStart = 0.0f;
    private float mousePosY;


    // Start is called before the first frame update
    void Start()
    {
        sodaSprite = GetComponent<SpriteRenderer>();
        //mousePosY = Mathf.Clamp(yStart, yMin, yMax);
        
    }

    // Update is called once per frame
    void Update()
    {

        GameObject  gun = shooter.gun;

        
    //Makes the gun follow the cursor & constrain the height of the mouseY
        Vector3 mousePosition = Input.mousePosition;
        Vector3 gunPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, depth));
        gun.transform.position = gunPosition;

        if (gunPosition.x < 0)
        {
            sodaSprite.flipX = false;
        }
        else
        {
            sodaSprite.flipX = true;
        } 
        
    }

}
