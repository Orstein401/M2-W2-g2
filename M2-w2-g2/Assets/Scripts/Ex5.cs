using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex5 : MonoBehaviour
{
    [SerializeField] private int numberToFind;
    [SerializeField] private int arraySize;
    [SerializeField] private int offSet;

    void Start()
    {
        int[] array=new int[arraySize];
        Random.Range(0, arraySize);
        for(int i = 0; i < arraySize; i++)
        {
            array[i] = Random.Range(numberToFind-offSet, numberToFind+offSet);
            Debug.Log(array[i]);
            if (array[i] == numberToFind)
            {
                Debug.Log("Found");
            }
            else
            {
                Debug.Log("not Found");
            }
        }
        Debug.Log("iteration Finished");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
