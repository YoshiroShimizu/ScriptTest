using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;         // 体力
    private int power = 25; // 攻撃力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
    }

}


public class Test : MonoBehaviour
{


    void Start()
    {
        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す
        lastboss.Attack();
        //防御用の関数を呼び出す
        lastboss.Defence(3);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //要素5の配列を初期化する
        int[] array = { 100, 80, 150, 200, 190 };

        //配列の要素数の分だけ処理を繰り返す
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //要素5の配列を初期化する
        int[] array = { 100, 80, 150, 200, 190 };

        //配列の要素数の分だけ処理を繰り返す
        for (int i = 4; i < array.Length; i--)
        {
            if (i >= 0)
            {
                Debug.Log(array[i]);
            }
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}

