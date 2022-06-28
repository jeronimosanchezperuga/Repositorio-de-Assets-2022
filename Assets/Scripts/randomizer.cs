using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomizer : MonoBehaviour
{
    public GameObject myPlatformCenter;
    public GameObject myPlatformBorder;

    GameObject myPlatformCenterClone;
    GameObject myPlatformBorderClone;
    GameObject myPlatformCenterClone2;
    GameObject myPlatformBorderClone2;
    GameObject myPlatformCenterClone3;
    GameObject myPlatformBorderClone3;
    GameObject myPlatformCenterClone4;
    GameObject myPlatformBorderClone4;
    GameObject myPlatformCenterClone5;
    GameObject myPlatformBorderClone5;
    GameObject myPlatformCenterClone6;
    GameObject myPlatformBorderClone6;
    GameObject myPlatformCenterClone7;
    GameObject myPlatformBorderClone7;
    GameObject myPlatformCenterClone8;
    GameObject myPlatformBorderClone8;

    public GameObject myPlatform;

    GameObject myPlatformClone;
    GameObject myPlatformClone2;
    GameObject myPlatformClone3;
    GameObject myPlatformClone4;
    GameObject myPlatformClone5;
    GameObject myPlatformClone6;
    GameObject myPlatformClone7;
    GameObject myPlatformClone8;

    // Start is called before the first frame update
    void Start()
    {
        float randomPositionX1 = Random.Range(-20, 21);
        myPlatformCenterClone = Instantiate(myPlatformCenter, new Vector3(randomPositionX1, 0, 22), Quaternion.Euler(270, 0, 0));
        myPlatformBorderClone = Instantiate(myPlatformBorder, new Vector3(randomPositionX1, 0, 22), Quaternion.Euler(270, 0, 0));

        float randomPositionX2 = Random.Range(-20, 21);
        myPlatformCenterClone2 = Instantiate(myPlatformCenter, new Vector3(randomPositionX2, 0, 42), Quaternion.Euler(270, 0, 0));
        myPlatformBorderClone2 = Instantiate(myPlatformBorder, new Vector3(randomPositionX2, 0, 42), Quaternion.Euler(270, 0, 0));

        float randomPositionX3 = Random.Range(-20, 21);
        myPlatformCenterClone3 = Instantiate(myPlatformCenter, new Vector3(randomPositionX3, 0, 62), Quaternion.Euler(270, 0, 0));
        myPlatformBorderClone3 = Instantiate(myPlatformBorder, new Vector3(randomPositionX3, 0, 62), Quaternion.Euler(270, 0, 0));

        float randomPositionX4 = Random.Range(-20, 21);
        myPlatformCenterClone4 = Instantiate(myPlatformCenter, new Vector3(randomPositionX4, 0, 82), Quaternion.Euler(270, 0, 0));
        myPlatformBorderClone4 = Instantiate(myPlatformBorder, new Vector3(randomPositionX4, 0, 82), Quaternion.Euler(270, 0, 0));

        float randomPositionX5 = Random.Range(-20, 21);
        myPlatformCenterClone5 = Instantiate(myPlatformCenter, new Vector3(randomPositionX5, 0, 102), Quaternion.Euler(270, 0, 0));
        myPlatformBorderClone5 = Instantiate(myPlatformBorder, new Vector3(randomPositionX5, 0, 102), Quaternion.Euler(270, 0, 0));

        float randomPositionX6 = Random.Range(-20, 21);
        myPlatformCenterClone6 = Instantiate(myPlatformCenter, new Vector3(randomPositionX6, 0, 122), Quaternion.Euler(270, 0, 0));
        myPlatformBorderClone6 = Instantiate(myPlatformBorder, new Vector3(randomPositionX6, 0, 122), Quaternion.Euler(270, 0, 0));

        float randomPositionX7 = Random.Range(-20, 21);
        myPlatformCenterClone7 = Instantiate(myPlatformCenter, new Vector3(randomPositionX7, 0, 142), Quaternion.Euler(270, 0, 0));
        myPlatformBorderClone7 = Instantiate(myPlatformBorder, new Vector3(randomPositionX7, 0, 142), Quaternion.Euler(270, 0, 0));

        float randomPositionX8 = Random.Range(-20, 21);
        myPlatformCenterClone8 = Instantiate(myPlatformCenter, new Vector3(randomPositionX8, 0, 162), Quaternion.Euler(270, 0, 0));
        myPlatformBorderClone8 = Instantiate(myPlatformBorder, new Vector3(randomPositionX8, 0, 162), Quaternion.Euler(270, 0, 0));

        //float randomPositionX1 = Random.Range(-20, 21);
        //myPlatformClone = Instantiate(myPlatform, new Vector3(randomPositionX1, 0, 22), Quaternion.identity); // Quaternion identity hace que la rotacion del objeto sea la misma que la del prefab, no es necesario pero si lo es para poner el vector3 en esta linea
        //myPlatformClone.name = "platform1";

        //float randomPositionX2 = Random.Range(-20, 21);
        //myPlatformClone2 = Instantiate(myPlatform, new Vector3(randomPositionX2, 0, 42), Quaternion.identity);
        //myPlatformClone2.name = "platform2";

        //float randomPositionX3 = Random.Range(-20, 21);
        //myPlatformClone3 = Instantiate(myPlatform, new Vector3(randomPositionX3, 0, 62), Quaternion.identity);
        //myPlatformClone3.name = "platform3";

        //float randomPositionX4 = Random.Range(-20, 21);
        //myPlatformClone4 = Instantiate(myPlatform, new Vector3(randomPositionX4, 0, 82), Quaternion.identity);
        //myPlatformClone4.name = "platform4";

        //float randomPositionX5 = Random.Range(-20, 21);
        //myPlatformClone5 = Instantiate(myPlatform, new Vector3(randomPositionX5, 0, 102), Quaternion.identity);
        //myPlatformClone5.name = "platform5";

        //float randomPositionX6 = Random.Range(-20, 21);
        //myPlatformClone6 = Instantiate(myPlatform, new Vector3(randomPositionX6, 0, 122), Quaternion.identity);
        //myPlatformClone6.name = "platform6";

        //float randomPositionX7 = Random.Range(-20, 21);
        //myPlatformClone7 = Instantiate(myPlatform, new Vector3(randomPositionX7, 0, 142), Quaternion.identity);
        //myPlatformClone7.name = "platform7";

        //float randomPositionX8 = Random.Range(-20, 21);
        //myPlatformClone8 = Instantiate(myPlatform, new Vector3(randomPositionX8, 0, 162), Quaternion.identity);
        //myPlatformClone8.name = "platform8";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
