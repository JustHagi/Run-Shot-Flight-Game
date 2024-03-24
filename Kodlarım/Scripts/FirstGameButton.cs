using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class FirstGameButton : MonoBehaviour
{

    public void Menuyedon()
    {
        SceneManager.LoadScene(0);
    }

    public void Tekraroyna()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(1);
    }
    public void Menuyedon2()
    {
        SceneManager.LoadScene(0);
    }

    public void Tekraroyna2()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(2);
    }
}
