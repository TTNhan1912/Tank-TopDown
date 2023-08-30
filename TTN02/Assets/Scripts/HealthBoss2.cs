using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBoss2 : MonoBehaviour
{
    public float mauBoss;
    public GameObject win;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Dan"))
        {
            mauBoss -= 2;
            if (mauBoss <= 0)
            {
                Destroy(gameObject);
                WinGame();
            }
        }
    }

    public void WinGame()
    {
        win.SetActive(true);
        Time.timeScale = 0;

    }

}
