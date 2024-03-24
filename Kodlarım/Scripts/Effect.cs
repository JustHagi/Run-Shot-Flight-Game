using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    public GameObject effectObject; // Oynatmak istedi�iniz efektin referans�

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // "Fire1" girdisi (fare t�klama) alg�land� m�?
        {
            PlayEffect();
        }
    }

    void PlayEffect()
    {
        if (effectObject != null)
        {
            Instantiate(effectObject, transform.position, Quaternion.identity);
            // Yukar�daki sat�r, belirledi�iniz efekti mevcut konumda oynat�r.
        }
    }
}
