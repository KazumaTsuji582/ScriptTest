using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�v�f��5�̔z��
        int[] array = { 70,30,50,60,100 };

        //for�����g���A�z��̊e�v�f�̒l�����Ԃɕ\������
        Debug.Log("���Ԃɕ\��");
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //�z��̊e�v�f�̒l���t���ɕ\������
        Debug.Log("�t���ɕ\��");
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
