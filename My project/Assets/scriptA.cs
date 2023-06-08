using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptA : MonoBehaviour
{
    [SerializeField] private float age;
    [SerializeField] private float weight;
    [SerializeField] private bool isStudying;

    private void Start()
    {
        if (!isStudying)
        {
            if (age == 18 && weight < 100)
            {
                Debug.Log("Askerlik g�revine �a��r�ld�n�z.");
            }
        }
        else if (age > 18 && weight < 100)
        {
            float delay = age - 18;
            Debug.Log("Askerlik g�revi i�in " + delay + "y�l ge� kald�n�z. L�tfen birli�e teslim olunuz");
        }

    }


    // Update is called once per frame
    void Update()
    {

    }
}
