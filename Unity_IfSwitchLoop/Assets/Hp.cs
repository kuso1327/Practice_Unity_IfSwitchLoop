using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms;

public class Hp : MonoBehaviour
{
    public Slider hp_controller;
    private int _hp;
    public int hp { get => _hp; set => _hp = value; }
    [Header("文字")]
    public Text result;


    public void Update()
    {
        hp = (int)hp_controller.value;

        if (hp>= 70)
        {
            result.text = "<color=#007903>" + "安全"+ "</color>";
        }
        else if ( hp>= 30)
        {
            result.text = "<color=#E7982B>" + "警告"+ "</color>";
        }
        else
        {
            result.text = "<color=#BA1D1F>"+ "危險" + "</color>";
        }   
    }

    












}
