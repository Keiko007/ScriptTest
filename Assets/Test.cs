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


    // 攻撃用の関数
    public void Attack()
    {
         if (this.mp >5)
        {
            this.mp -= power;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }

        if (this.mp <5)
        {
            Debug.Log("MPが足りないため魔法が使えない");
        }
    }


}

public class test : MonoBehaviour
{ 
    // Start is called before the first frame update
    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();

    }

    // Update is called once per frame
    void Update()
    {

    }
}

