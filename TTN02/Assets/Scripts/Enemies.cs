using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Enemies : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Dan") )
        {
            Destroy(gameObject);

        }

        if (collision.gameObject.CompareTag("abc"))
        {
            Destroy(gameObject);
            Debug.Log("??????");
        }


    }




}
