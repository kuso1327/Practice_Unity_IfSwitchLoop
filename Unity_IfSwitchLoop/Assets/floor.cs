using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    [Header("地板")]
    public GameObject cube;

    public void creatfloor(int length)
    {
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Instantiate(cube, new Vector3(i *2, j*2, 0), Quaternion.Euler(270, 0, 0));
            }
        }
    }

    /*老師的方法
        private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < (i+1); j++)
            {
                Vector3 pos = new Vector3(i * 2, j * 2, 0);
                Instantiate(cube, pos,Quaternion.identity);
            }
        }
    }
    */
    private void Awake()
    {
        creatfloor(10);

    }


}
