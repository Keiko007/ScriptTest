using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{

    // Start is called before the first frame update
   void Start()
    {
        int[] points = { 10, 20, 30, 40, 50 };

        for (int i = 0; i < points.Length; i++)
        {
            Debug.Log(points[i]);
        }


        for (int j =  points.Length - 1; j >= 0;  j--)
        {
            Debug.Log(points[j]);
        }
    }

//Update is called once per frame
    void Update()
    {
    }
}

public class Boss
{
    private int mp = 53;
    private int power = 5;


    // �U���p�̊֐�
    public void Attack()
    {
         if (this.mp >5)
        {
            this.mp -= power;
            Debug.Log("���@�U���������B�c��MP��" + this.mp);
        }

        if (this.mp <5)
        {
            Debug.Log("MP������Ȃ����ߖ��@���g���Ȃ�");
        }
    }


}

public class test : MonoBehaviour
{ 
    // Start is called before the first frame update
    void Start()
    {
        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        // �U���p�̊֐����Ăяo��
        lastboss.Attack();

    }

    // Update is called once per frame
    void Update()
    {

    }
}

