using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpamQuai : MonoBehaviour
{
    public GameObject viTriSpam;
    Vector3 viTri;
    public GameObject quai;

    public float istime;
    public float isSpawm;
    private float timeSpawn;
    // Start is called before the first frame update
    void Start()
    {
        viTri = viTriSpam.transform.position;
        timeSpawn = istime;
    }

    // Update is called once per frame
    void Update()
    {
        isSpawm -= Time.deltaTime;
        if (isSpawm < 0)
        {
            isSpawm = 0;
            istime -= Time.deltaTime;
            if (istime < 0)
            {
                istime = timeSpawn;
                var quaiii = Instantiate(quai, viTri, Quaternion.identity);
            }
        }
    }
}
