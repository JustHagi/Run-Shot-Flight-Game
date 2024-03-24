using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SecondGameController : MonoBehaviour
{
    public CharacterController controller;
    public float hiz = 5f;
    public float yercekimi = -9.81f;
    public float jumpheight = 3f;

    public Transform groundcheck;
    public float grounddistance = 0.4f;
    public LayerMask groundmask;

   
    Vector3 velocity;
    bool grounded;

    void Update()
    {
        grounded = Physics.CheckSphere(groundcheck.position, grounddistance, groundmask);

        if (grounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            velocity.y = Mathf.Sqrt(jumpheight * -2f * yercekimi);
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * hiz * Time.deltaTime);

        velocity.y += yercekimi * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }
}
