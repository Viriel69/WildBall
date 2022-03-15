using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool paused;

    public void PauseGameActivate() 
    {
        Time.timeScale = 0;
    }
    public void PauseGameDeactivate() 
    {
        Time.timeScale = 1;
    }
}
