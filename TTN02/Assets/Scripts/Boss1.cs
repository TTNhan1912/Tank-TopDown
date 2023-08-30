using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1 : MonoBehaviour
{
    public float mauBoss;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Dan"))
        {
            mauBoss -= 2;
            if(mauBoss <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

}
