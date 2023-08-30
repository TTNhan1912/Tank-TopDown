using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nong2 : MonoBehaviour
{
    public GameObject dan1;
    public GameObject dan;
    public Transform firePoints1;
    public Transform firePoints2;
    public float lucBan;

    // Start is called before the first frame update


    public void Ban2Vien()
    {
        GameObject projectile1 = Instantiate(dan, firePoints1.position, firePoints1.rotation);
        projectile1.GetComponent<Rigidbody2D>().AddForce(firePoints1.up * lucBan, ForceMode2D.Impulse);

        GameObject projectile2 = Instantiate(dan, firePoints2.position, firePoints2.rotation);
        projectile2.GetComponent<Rigidbody2D>().AddForce(firePoints2.up * lucBan, ForceMode2D.Impulse);


    }


}
