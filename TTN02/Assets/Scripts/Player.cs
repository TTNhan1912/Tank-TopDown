using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Camera Camera;

    [SerializeField] private float speedWalk;
    private Rigidbody2D rb;
    private float runX,runY;

    public Weapont weapont;
    public Nong nong;
    public Diem diem;
    public GameObject[] nongSung;
    public GameObject[] phiTieu;
    public GameObject pause;
    private Vector2 moveInput;

    private Vector2 mousePosition;

    // nhạc
    private AudioSource audioSource;
    private AudioClip coins;

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        audioSource= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        runX = Input.GetAxis("Horizontal");
        runY = Input.GetAxis("Vertical");
        moveInput = new Vector3(runX, runY, 0).normalized;

        rb.velocity = new Vector2(runX * speedWalk, runY * speedWalk);
        mousePosition = Camera.ScreenToWorldPoint(Input.mousePosition);


        Click();
        DiChuyen();
    }

    public void Click()
    {
        if(Input.GetMouseButtonDown(0))
        {
            nong.BanDann();
            /*weapont.FireBullet();*/
            PlaySound("Gun");
        }
    }

    private void PlaySound(string name)
    {
        audioSource.PlayOneShot(Resources.Load<AudioClip>(name));
    }

    void DiChuyen()
    {
        
        // quay nv theo mouse
        Vector2 animDerection = mousePosition - rb.position;
        float aniAngle = Mathf.Atan2(animDerection.y, animDerection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aniAngle;
    }

    public void TangTocDoDiChuyen()
    {
        speedWalk += 3f;
        Time.timeScale = 1;
    }
    public void TangTocDoDiChuyen2()
    {
        speedWalk += 3f;
        Time.timeScale = 1;
    }
    public void TangTocDoDiChuyen3()
    {
        speedWalk += 3f;
        Time.timeScale = 1;
    }
    public void TangTocDoDiChuyen4()
    {
        speedWalk += 3f;
        Time.timeScale = 1;
    }


    public void NangcapSung()
    {
        nongSung[0].SetActive(false);
        nongSung[1].SetActive(true);
        Time.timeScale = 1;

        nong.lucBan += 10f;

    }
    public void NangcapSung2()
    {
        nongSung[1].SetActive(false);
        nongSung[2].SetActive(true);
        Time.timeScale = 1;

        nong.lucBan += 10f;
    }  
    public void NangcapSung3()
    {
        nongSung[2].SetActive(false);
        nongSung[3].SetActive(true);
        Time.timeScale = 1;

        nong.lucBan += 10f;
    }

    public void PhiTieu1()
    {
        phiTieu[0].SetActive(true);
        Time.timeScale = 1;
    } 
    public void PhiTieu2()
    {
        phiTieu[1].SetActive(true);
        Time.timeScale = 1;
    }  
    public void PhiTieu3()
    {
        phiTieu[2].SetActive(true);
        Time.timeScale = 1;
    }
    public void PhiTieu4()
    {
        phiTieu[3].SetActive(true);
        Time.timeScale = 1;
    }

    public void Pause()
    {
        Time.timeScale = 0;
        pause.SetActive(true);
    }

    public void Con()
    {
        if (Time.timeScale != 1)
        {
            Time.timeScale = 1;
        }
    }

    public void Quit()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;

    }
    public void NewGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

}
