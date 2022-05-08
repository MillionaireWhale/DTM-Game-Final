using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point_Script : MonoBehaviour
{
    Text counterText;
    // Start is called before the first frame update
    void Start()
    {
        //Allows text to be printed
        counterText = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    //Sets the current amount of point adders to the point display
    {
        //Adds points to the total points display
        if (counterText != null && counterText.text != Point_adder.totalPoints.ToString())
        {
            counterText.text = Point_adder.totalPoints.ToString();
        }
    }
}
