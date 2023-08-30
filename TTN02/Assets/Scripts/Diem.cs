using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Diem : MonoBehaviour
{
    public TextMeshProUGUI diem;
    public TextMeshProUGUI diemwin;
    public TextMeshProUGUI diemlose;

    public float diemcount;
    public float diemsize = 20f;
    public float diemluu;

    HealthBoss2 HealthBoss2;
    public GameObject[] capDo;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        diemcount += Dan.isdiem;
        Dan.isdiem = 0;

        if (diemcount == 20)
        {
            diemcount += 1f;
            diemsize = 51;
            Time.timeScale = 0;
            capDo[0].SetActive(true);
        }

        if (diemcount == 51)
        {
            diemcount += 1f;
            diemsize = 112;
            Time.timeScale = 0;
            capDo[1].SetActive(true);
        }
        
        if (diemcount == 112)
        {
            diemcount += 1f;
            diemsize = 173;
            Time.timeScale = 0;
            capDo[2].SetActive(true);
        }
        if (diemcount == 173)
        {
            diemcount += 1f;
            diemsize = 212;
            Time.timeScale = 0;
            capDo[3].SetActive(true);
        }
        if (diemcount == 212)
        {
            diemcount += 1f;
            diemsize = 413;
            Time.timeScale = 0;
            capDo[4].SetActive(true);
        }
        if (diemcount == 413)
        {
            diemcount += 1f;
            diemsize = 500;
            Time.timeScale = 0;
            capDo[5].SetActive(true);
        }
        if(diemcount > 600)
        {
            capDo[6].SetActive(true);
            Time.timeScale = 0;
            HealthBoss2.WinGame();

        }

        else
        {
            diem.text = diemcount.ToString() + " / " + diemsize.ToString();
        }

        diemwin.text = diemcount.ToString();
        diemlose.text = diemcount.ToString();

    }




    /*    public void CongDiem(int diemCount)
        {
            diemTong += diemCount;
            diemCurrent.text = " / " + diemTong.ToString();

        }*/
}
