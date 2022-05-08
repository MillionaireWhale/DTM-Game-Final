using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Player; //Public variable to store a reference to the player game object
    private Vector3 offset; //Private variable to store the offset distance between the player and camera
    // Start is called before the first frame update
    void Start()
    {
        //Calculates and stores the offset value by getting the distance between the camera's position and the player's position
        offset = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Set the position of the camera's transform to be the same as the player's
        transform.position = Player.transform.position + offset;
    }
}
