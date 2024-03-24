using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



[System.Serializable]
public enum SIDE { left = -3, Mid, Right = 3 }

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public SIDE m_Side = SIDE.Mid;
    float NewXPos = 0f;

    [HideInInspector]
    public bool Swipeleft, SwipeRight, SwipeUp;
    public float XValue;
    private CharacterController m_char;
    private float x;
    public float SpeedDodge;
    private float y;
    public float FwdSpeed;
    public GameObject gameOverScreen;
    public GameObject bitti_pnl;
    public GameObject ayarlar;
    public float jumpPower = 7f;
    public bool InJump;
    private bool settingsMenuOpen = false;


    public TMPro.TextMeshProUGUI puan_txt;
    public TMPro.TextMeshProUGUI toplanan_altýn_txt;

    private float currentScore = 0;
    int toplanan_altýn = 0;


    public Transform Ground1;
    public Transform Ground2;
    public Transform Ground3;

    public AudioClip coinSound; // Coin toplandýðýnda çalacak ses dosyasý
    private AudioSource audioSource; // Ses kaynaðý
    public AudioSource runningSound;



    private void Start()
    {
        m_char = GetComponent<CharacterController>();
        transform.position = Vector3.zero;
        audioSource = GetComponent<AudioSource>();
        runningSound = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }
    private void Update()
    {
        Swipeleft = Input.GetKeyDown(KeyCode.A);
        SwipeRight = Input.GetKeyDown(KeyCode.D);
        SwipeUp = Input.GetKeyDown(KeyCode.Space);

        if (Swipeleft)
        {
            if (m_Side == SIDE.Mid)
            {
                NewXPos = -XValue;
                m_Side = SIDE.left;
            }
            else if (m_Side == SIDE.Right)
            {
                NewXPos = 0;
                m_Side = SIDE.Mid;
            }
        }
        else if (SwipeRight)
        {
            if (m_Side == SIDE.Mid)
            {
                NewXPos = XValue;
                m_Side = SIDE.Right;
            }
            else if (m_Side == SIDE.left)
            {
                NewXPos = 0;
                m_Side = SIDE.Mid;

            }
        }

        Vector3 moveVector = new Vector3(x - transform.position.x, y * Time.deltaTime, FwdSpeed * Time.deltaTime);
        x = Mathf.Lerp(x, NewXPos, Time.deltaTime * SpeedDodge);
        m_char.Move(moveVector);
        Jump();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!settingsMenuOpen)
            {
                OpenSettings();
            }
            else
            {
                CloseSettings();
            }
        }

    }

    public void Jump()
    {
        if (m_char.isGrounded)
        {
            if (SwipeUp)
            {
                y = jumpPower;

            }
        }
        else
        {
            y -= jumpPower * 2 * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == ("Son_1"))
        {
            Ground3.position = new Vector3(Ground2.position.x, Ground2.position.y, Ground2.position.z + 91.0f);
        }
        if (other.gameObject.name == ("Son_2"))
        {
            Ground1.position = new Vector3(Ground3.position.x, Ground3.position.y, Ground3.position.z + 91.0f);
        }
        if (other.gameObject.name == ("Son_3"))
        {
            Ground2.position = new Vector3(Ground1.position.x, Ground1.position.y, Ground1.position.z + 91.0f);
        }
        if (other.gameObject.tag == "altin")
        {
            if (coinSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(coinSound);
            }
            Destroy(other.gameObject);

            toplanan_altýn++;
            currentScore += 5;
            puan_txt.text = currentScore.ToString("0000");
            toplanan_altýn_txt.text = toplanan_altýn.ToString();
        }
        if (other.gameObject.tag == "engel")
        {
            StopRunningSound();
            bitti_pnl.SetActive(true);
            Time.timeScale = 0.0f;
        }
        if (other.gameObject.name == "bitis_cizgisi")
        {
            gameOverScreen.SetActive(true);
            Time.timeScale = 0.0f;
            StopRunningSound();
        }

    }
    private void StopRunningSound()
    {
        if (runningSound != null && runningSound.isPlaying)
        {
            runningSound.Stop();
        }
    }
    private void PlayRunningSound()
    {
        runningSound.Play();
    }
    public void OpenSettings()
    {
        ayarlar.SetActive(true);
        Time.timeScale = 0.0f;
        StopRunningSound();
        settingsMenuOpen = true;
    }
    void CloseSettings()
    {
        ayarlar.SetActive(false);
        Time.timeScale = 1f;
        settingsMenuOpen = false;
        PlayRunningSound();
    }
}
