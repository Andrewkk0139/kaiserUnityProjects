using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Object that will attach to the script for spawning objects
    [Header("Spikes Objects for controlling the game")] //Header when using the script in the inspector
    public GameObject spikes; //Lets you pass certain data types to it, this case a gameObject.
    //height position of the spikes
    [Header("Default Height")]
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateObjects", 1f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(5, Random.range(-height, height), 0);   
    }
}

    void InstantiateObjects()
    {
    Instantiate(spikes, transform.position, transform.rotation);    
    }
