using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Victory_Trigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Loads Death Scene when the Collider is triggered
        SceneManager.LoadScene("Victory screen", LoadSceneMode.Single);
    }
}
