using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class KillCounter : MonoBehaviour
{
    public Text counterText;
    int kills;
    public GameObject gameOverScreen;

    public int targetCount = 8;
    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowKills();
    }
    private void ShowKills()
    {
        if (!isGameOver)
        {
            counterText.text = kills.ToString() + "/8";

            if (kills >= targetCount)
            {
                EndGame();
            }
        }
    }
    public void EndGame()
    {
        isGameOver = true;
        gameOverScreen.SetActive(true);
        Time.timeScale = 0.0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void AddKill()
    {
        kills++;
    }
}
