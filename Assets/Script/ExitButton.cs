using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Q))
        {
            ExitGame();
        }   
    }

    public void ExitGame() 
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
