using UnityEngine;
using System;
using UnityEngine.UI;

public class Inputfield : MonoBehaviour
{
    [Header("輸入欄位")]
    public InputField Inputtext;
    [Header("顯示結果")]
    public Text result;


    private void Update()
    {
        print(Inputtext.text);
        //顯示結果.文字=輸入欄位==紅水?恢復血量:輸入欄位==藍水?恢復魔力:"";
        result.text = Inputtext.text == "紅水" ? "<color=#D92222>" + "恢復血量" + "</color>" :Inputtext.text == "藍水" ? "<color=#1B4AB7>" + "恢復魔力" + "</color>" : "";
       /*
        if(Inputtext.text == "紅水")
        {
            result.text = "恢復血量";
        }
        else
        {
            result.text = "";
        }
        */
    }
}
