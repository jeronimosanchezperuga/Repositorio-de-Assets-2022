using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereMultiplier : MonoBehaviour
{
    public GameObject mySphere;
    GameObject mySphereClone;
    int sphereQuantity = 3;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i <= sphereQuantity; i++)
        {
            mySphereClone = Instantiate(mySphere);
            Destroy(mySphereClone, 5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
