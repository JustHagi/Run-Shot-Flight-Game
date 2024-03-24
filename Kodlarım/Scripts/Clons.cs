using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clons : MonoBehaviour
{
    public GameObject altin;
    public GameObject araba;
    public GameObject kaya;


    public Transform oyuncu;

    float silinme_zamani = 5.0f;

    float sag_koordinat = 3f;
    float sol_koordinat = -3f;
    float orta = 0f;

    private void Start()
    {
        InvokeRepeating("nesne_klonla", 0, 0.5f);
    }
    void nesne_klonla()
    {
        int rastsayi = Random.Range(0, 100);

        if (rastsayi > 0 && rastsayi < 80)
        {
            klonla(altin, 1.0f);
        }
        if (rastsayi > 70 && rastsayi < 85)
        {
            klonla(araba, 0.7f);
        }
        if(rastsayi>85 && rastsayi < 95)
        {
            klonla2(kaya, 0.02f);
        }
    }
    void klonla(GameObject nesne, float Y_koordinat)
    {
        GameObject yeni_klon = Instantiate(nesne);

        int rastsayi = Random.Range(0, 100);

        if (rastsayi < 50)
        {
            yeni_klon.transform.position = new Vector3(sag_koordinat, Y_koordinat, oyuncu.position.z + 20.0f);
        }
        else if (rastsayi > 50)
        {
            yeni_klon.transform.position = new Vector3(sol_koordinat, Y_koordinat, oyuncu.position.z + 20.0f);
        }

        Destroy(yeni_klon, silinme_zamani);

    }
    void klonla2(GameObject nesnee, float Y_koordinat)
    {
        GameObject yeni_klon = Instantiate(nesnee);

        int rastsayi = Random.Range(0, 100);

        if (rastsayi < 50)
        {
            yeni_klon.transform.position = new Vector3(orta, Y_koordinat, oyuncu.position.z + 20.0f);
        }
        else if (rastsayi > 50)
        {
            yeni_klon.transform.position = new Vector3(orta, Y_koordinat, oyuncu.position.z + 20.0f);
        }
        Destroy(yeni_klon, silinme_zamani);
    }
}
