using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GunShot : MonoBehaviour
{
    public float damage = 10f;
    public float firingrate = 15f;
    public float impactForce = 100f;
    public float range = 100f;
    public Camera fpscamera;
    private float nexttimetofire = 0f;
    

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Time.time >= nexttimetofire)
        {
            nexttimetofire=Time.time+ 1f / firingrate;
            shoot();
        }
       
    }
    void shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpscamera.transform.position, fpscamera.transform.forward, out hit, range))
        {
            

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
            target target = hit.transform.GetComponent<target>();
            if (target != null)
            {
                target.TakeDamage(damage);
                
            }
        }
    }
}
