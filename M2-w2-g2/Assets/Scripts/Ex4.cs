using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex4 : MonoBehaviour
{
    [SerializeField] private int startNumber;
    [SerializeField] private int amount;

    void Start()
    {
        for (int i = 0;i<= amount; i++)
        {
            Debug.Log(startNumber);
            startNumber++;
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
