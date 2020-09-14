using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    public int mp = 53;

    public void Magic(int mpCost)
    {
        if (this.mp >= 5)
        {
            this.mp -= mpCost;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            this.mp -= mpCost;
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 0, 1, 2, 3, 4 };
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

            Boss zakoboss = new Boss();

        for (zakoboss.mp = 53; zakoboss.mp > 0; zakoboss.Magic(5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
