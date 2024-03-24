using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    public GameObject effectObject; // Oynatmak istediðiniz efektin referansý

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // "Fire1" girdisi (fare týklama) algýlandý mý?
        {
            PlayEffect();
        }
    }

    void PlayEffect()
    {
        if (effectObject != null)
        {
            Instantiate(effectObject, transform.position, Quaternion.identity);
            // Yukarýdaki satýr, belirlediðiniz efekti mevcut konumda oynatýr.
        }
    }
}
