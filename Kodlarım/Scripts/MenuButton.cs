using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class MenuButton : MonoBehaviour
{
    public GameObject level_panel;
    public GameObject settings_panel;
    public GameObject creator_panel;
    public GameObject exitsettings_button;
    public GameObject exitsettings2_button;
    public GameObject exitsettings3_button;
    public GameObject exitsettings4_button;
    public GameObject button_panel;
    public GameObject openbutton_panel;
    public GameObject kontrol_panel;
    
    public void KontrolPanel()
    {
        kontrol_panel.SetActive(true);
    }
    public void Start_Button()
    {
        level_panel.SetActive(true);
    }
    public void Settings_Button()
    {
        settings_panel.SetActive(true);
    }
    public void Creator_Button()
    {
        creator_panel.SetActive(true);
    }
    public void Level1_Button()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }
    public void Level2_Button()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1.0f;
    }
    public void Level3_Button()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1.0f;
    }
    public void Exit_Button()
    {
        exitsettings_button.SetActive(false);
        exitsettings2_button.SetActive(false);
        exitsettings3_button.SetActive(false);
        exitsettings4_button.SetActive(false);

    }
    public void Panel_Button()
    {
        button_panel.SetActive(false);
    }
    public void OpenButton_Panel()
    {
        openbutton_panel.SetActive(true);
    }
  
   
}
