using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapont : MonoBehaviour
{
    public GameObject bullet;

    public Transform firePoint;

    public float lucban;
    // Start is called before the first frame update
    public void FireBullet()
    {

        Instantiate(bullet, firePoint.position, transform.rotation);

    }
}
