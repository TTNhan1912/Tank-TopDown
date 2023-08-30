using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VienDan : MonoBehaviour
{
    public Rigidbody2D rb;

    [SerializeField]public ParticleSystem  impactEffect;

    private void Update()
    {
        Impact();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Wall":
                Destroy(gameObject);
                Debug.Log(">>>>>>>>>");
                Impact();

                break;
            case "Enemies":
                Destroy(gameObject);
                Impact();
                break;
            

        }
    }

    public void Impact()
    {
        Instantiate(impactEffect, transform.position, Quaternion.identity);
        Destroy(gameObject,2);
    }


}
