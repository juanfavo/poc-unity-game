using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicScript : MonoBehaviour
{
    public void exitGame ()
    {
        Debug.Log("Saliendo del juego...");
        Application.Unload();
    }
}
