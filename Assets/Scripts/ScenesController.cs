using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesController : MonoBehaviour
{
    public int index;
    public void ChangeScene() 
    {
        SceneManager.LoadScene(index);
        Time.timeScale = 1;
    }
}
