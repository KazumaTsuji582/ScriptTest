using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;          // MP

    // mp������Ė��@�U��������֐�
    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + mp + "�B");
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }

    }
}

    public class Test : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            //�v�f��5�̔z��
            int[] array = { 70, 30, 50, 60, 100 };

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

            // Boss�N���X�̃C���X�^���X���쐬
            Boss boss = new Boss();
            // Magic�֐���10��g��
            for (int i = 0; i < 10; i++)
            {
                boss.Magic();
            }
            // Magic�֐�11��ځAmp������Ȃ����Ƃ��m�F
            boss.Magic();
        }


        // Update is called once per frame
        void Update()
        {

        }
    }
