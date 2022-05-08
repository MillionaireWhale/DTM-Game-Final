using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Death : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Loads Death Scene when the Collider is triggered
        SceneManager.LoadScene("Death Screen", LoadSceneMode.Single);
    }
}
