using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extra : MonoBehaviour
{
    [SerializeField] private int num;
    void Start()
    {
        Debug.Log("tabellina del cinque");
        int tabe;
        for (int i = 1;i <= 10; i++)
        {
            tabe = 5 * i;
            Debug.Log(tabe);
        }
        Debug.Log("tabellina tua");
        for (int i = 1; i <= 10; i++) {
            tabe = num * i;
            Debug.Log(tabe);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
