using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ex3 : MonoBehaviour
{
    [SerializeField] private int num = 30;
    void Start()
    {
        for (int i = 0; i <= num; i++) { 
            if (i % 3==0 && i % 5 == 0)
            {
                Debug.Log("FizzBuzz "+i);
               
            }
            else if (i % 3 == 0)
            {
                Debug.Log("Fizz "+i);
              
            }else if(i %5 == 0)
            {
                Debug.Log("Buzz " + i);
                

            }
            else
            {
                Debug.Log("nessuno dei due " + i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
