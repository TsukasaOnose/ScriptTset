﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 0, 15, 255, 4095, 65535};

        for (int i = array.Length - 1; i >=0; i--)
        {
                Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
