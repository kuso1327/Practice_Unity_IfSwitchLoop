using UnityEngine;
using System;
using UnityEngine.UI;

public class Inputfield : MonoBehaviour
{
    public InputField Inputtext;
    [Header("顯示結果")]
    public Text result;
    public string use;


    private void Update()
    {
        print(Inputtext.text);
        result.text = Inputtext.text == "紅水" ? "恢復血量" :Inputtext.text == "藍水" ? "恢復魔力":"";
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
