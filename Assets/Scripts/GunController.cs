using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{

    //script attached to the gun
    public Shoot shooter;
    //sprite of the soda we're instantiating
    SpriteRenderer sodaSprite;
    // z value of spray
    public float depth = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
        //disable cursor
        Cursor.visible = false;
        //get the sprite renderer of the soda so we can manipulate it later
        sodaSprite = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        //get the gameobject already in scene
        GameObject gun = shooter.gun;


        //Makes the gun follow the cursor
        Vector3 mousePosition = Input.mousePosition;
        Vector3 gunPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, depth));
        gun.transform.position = gunPosition;
        //flip the sprite if we're on the opposite side of the screen
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
