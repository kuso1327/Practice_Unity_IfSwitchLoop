using UnityEngine;
using System;
using UnityEngine.UI;

public class Method : MonoBehaviour
{
    public Hp _hp;
    public Text result;

    private void Start()
    {
        _hp.hp = 100;
    }

    public void Update()
    {
        if (_hp.hp >= 70)
        {
            result.text = "安全";
            print("安全");
        }
        else if (_hp.hp >= 30)
        {
            result.text = "警告";
            print("警告");
        }
        else
        {
            result.text = "危險";
            print("危險");
        }
    }
}
