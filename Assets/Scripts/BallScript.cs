using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    void SetBallColor(string color)
    {
        if (color == "red") GetComponent<SpriteRenderer>().color = Color.red;
        else if (color == "blue") GetComponent<SpriteRenderer>().color = Color.blue;
        else if (color == "green") GetComponent<SpriteRenderer>().color = Color.green;
        else GetComponent<SpriteRenderer>().color = Color.yellow;
    }
}
