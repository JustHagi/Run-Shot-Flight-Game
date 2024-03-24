using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelfinish : MonoBehaviour
{
    public void seviyebitir()
    {
        LevelManager.seviye2 = true;
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
    public void seviyebitir1()
    {
        LevelManager.seviye3 = true;
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
    
}
