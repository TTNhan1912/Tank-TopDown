using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]private int maxHealth ;
     int currentHealth;
    public ThanhMau thanhMau;

    public GameObject lose;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        thanhMau.UpdateMau(currentHealth, maxHealth);
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemies"))
        {
            currentHealth -= 2;
            thanhMau.UpdateMau(currentHealth, maxHealth);
            if (currentHealth <= 0)
            {
                Lose();
            }
        }
        if (collision.gameObject.CompareTag("Boss1"))
        {
            currentHealth -= 30;
            thanhMau.UpdateMau(currentHealth, maxHealth);
            if (currentHealth <= 0)
            {
                Lose();
            }
        }
        if (collision.gameObject.CompareTag("Boss2"))
        {
            currentHealth -= 40;
            thanhMau.UpdateMau(currentHealth, maxHealth);
            if (currentHealth <= 0)
            {
                Lose();
            }
        }
    }

    void Lose()
    {
        lose.SetActive(true);
        Time.timeScale = 0;
    }


}
