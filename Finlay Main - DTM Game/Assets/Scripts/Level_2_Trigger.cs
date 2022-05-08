using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level_2_Trigger: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Loads Level 2 when the player collides with the Level 2 trigger
        SceneManager.LoadScene("Level 2", LoadSceneMode.Single);
    }
}
