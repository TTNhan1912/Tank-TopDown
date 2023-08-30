using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nong : MonoBehaviour
{
    public GameObject vienDan;
    public Transform firePoints;
    public float lucBan;

    // Start is called before the first frame update


    public void BanDann()
    {
        GameObject projectile1 = Instantiate(vienDan, firePoints.position, firePoints.rotation);
        projectile1.GetComponent<Rigidbody2D>().AddForce(firePoints.up * lucBan, ForceMode2D.Impulse);

    }


}
