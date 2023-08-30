using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sung : MonoBehaviour
{
    public Camera Camera;
    private Rigidbody2D rb;
    private Vector2 mousePosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.ScreenToWorldPoint(Input.mousePosition);

        // quay nv theo mouse
        Vector2 animDerection = mousePosition - rb.position;
        float aniAngle = Mathf.Atan2(animDerection.y, animDerection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aniAngle;

    }
}
