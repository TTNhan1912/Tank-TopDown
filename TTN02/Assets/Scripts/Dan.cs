using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dan : MonoBehaviour
{
    public Rigidbody2D rb;
    public static int isdiem;


    [SerializeField] public ParticleSystem impactEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Wall":
                Destroy(gameObject);
                Debug.Log(">>>>>>>>>");
                /*Impact();*/

                break;
            case "Enemies":
                isdiem = 2;
                Destroy(gameObject);
                /*Impact();*/
                break;

            case "Boss1":
                Destroy(gameObject);
                /*Impact();*/
                break;

            case "Boss2":
                Destroy(gameObject);
                /*Impact();*/
                break;



        }
    }

    public void Impact()
    {
        Instantiate(impactEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }


}
