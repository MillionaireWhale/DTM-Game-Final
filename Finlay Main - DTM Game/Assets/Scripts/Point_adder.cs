using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point_adder : MonoBehaviour
{
    //Keeps track of the total amoint of Points gained
    public static int totalPoints = 0;
   
   void awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }
    void OnTriggerEnter2D(Collider2D c2d)
    {
        //Destorys coin upon collision with player
        if(c2d.CompareTag("Player"))
        {
            totalPoints++;
            Debug.Log(Point_adder.totalPoints);
            Destroy(gameObject);
        }
    }
}

