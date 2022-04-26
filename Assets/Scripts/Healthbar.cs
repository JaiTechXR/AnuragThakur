using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        slider.value = 0;
    }
    public void SetCoins(int coins){
        slider.value = coins;
    }

    public int GetCoins(){
        return Mathf.FloorToInt(slider.value);
    }
}
