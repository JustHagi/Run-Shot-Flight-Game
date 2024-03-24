using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    NewBehaviourScript player;
    Transform temas_kupu;

    float mesafe;

    private void Start()
    {
        player = GameObject.Find("player").GetComponent<NewBehaviourScript>();
        temas_kupu = GameObject.Find("player/temas_kup").transform;
    }
}
