using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ThanhMau : MonoBehaviour
{
    public Image fillBar;
    public TextMeshProUGUI valueText;

    public void UpdateMau(int curentValue, int maxValue)
    {
        fillBar.fillAmount = (float)curentValue / (float)maxValue;
        valueText.text = curentValue.ToString() + " / " + maxValue.ToString();
    }
}
