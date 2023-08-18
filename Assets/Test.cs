using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //要素数5の配列
        int[] array = { 70,30,50,60,100 };

        //for文を使い、配列の各要素の値を順番に表示する
        Debug.Log("順番に表示");
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //配列の各要素の値を逆順に表示する
        Debug.Log("逆順に表示");
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
