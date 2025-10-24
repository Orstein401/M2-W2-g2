using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2 : MonoBehaviour
{
    [SerializeField] private int numA;
    [SerializeField] private int numB;
    [SerializeField] private int numC;
    [SerializeField] private int numD;

    void Start()
    {
        int[] array= new int[4];
        array[0] = numA;
        array[1] = numB;
        array[2] = numC;
        array[3] = numD;
        int somma = 0;
        int molti = 1;
        for (int i=0; i<array.Length; i++)
        {
            somma = array[i] + somma;
            molti = array[i]*molti;
            
        }
        Debug.Log("questa è la somma " + somma + " questa è la moltiplicazione " + molti);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
