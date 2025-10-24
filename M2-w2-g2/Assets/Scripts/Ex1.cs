using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    [SerializeField] private int index;
    [SerializeField] private int num;

    void Start()
    {
        while (index>0) {
            Debug.Log(index +" indice "+num+" number");
            index--;
            num++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
