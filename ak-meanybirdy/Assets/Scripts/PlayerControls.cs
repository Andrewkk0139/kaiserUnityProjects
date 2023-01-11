using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //game manager object
    [Header("Game Controller Object for controlling the game.")]
    public GameController gameController;
    [Header("Default Velocity")]
    public float velocity = 5;          
    //phsyics for bird
    private Rigidbody2D rb;
    //Height of the bird on the y axis
    private float objectHeight;
    // Start is called before the first frame update
    void Start()
    {
        //Game controller componet
        gameController = GetComponent<GameController>();
        //Speed for the game is at a playing state
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
        //object height equals the size of the height of sprite
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //If the left mouse is clicked 
        if (Input.GetMouseButtonDown(0))
        {
            //the bird will rise in the y axis
            //then go back down
            rb.velocity = Vector2.up * velocity;
        }
    }
}
