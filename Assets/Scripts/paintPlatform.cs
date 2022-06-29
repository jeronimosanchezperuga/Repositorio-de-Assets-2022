using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintPlatform : MonoBehaviour
{
    public Material White;
    public Material Red;
    public Material Blue;
    public Material Yellow;
    public Material Green;
    public Collider myCollider;
    public int numberMaterial;

    bool theresCollision = true;

    public playerShoot scriptPlayerShoot;
    public playerSprayColor scriptPlayerSprayColor;

    // Start is called before the first frame update
    void Start()
    {
        scriptPlayerShoot = FindObjectOfType<playerShoot>();
        scriptPlayerSprayColor = FindObjectOfType<playerSprayColor>();

        float rng = Random.Range(1, 5);

        myCollider = GetComponent<BoxCollider>();

        if (rng == 1)
        {
            GetComponent<Renderer>().material = Red;
            numberMaterial = 1;
        }
        if (rng == 2)
        {
            GetComponent<Renderer>().material = Blue;
            numberMaterial = 2;
        }
        if (rng == 3)
        {
            GetComponent<Renderer>().material = Yellow;
            numberMaterial = 3;
        }
        if (rng == 4)
        {
            GetComponent<Renderer>().material = Green;
            numberMaterial = 4;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(scriptPlayerShoot.isHitting)
        {
            if(scriptPlayerShoot.hit.collider.gameObject == this.gameObject)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (numberMaterial == 1 && scriptPlayerSprayColor.selectedColor == 0) // si el spray es rojo
                    {
                        GetComponent<Renderer>().material = White;
                        Debug.Log("Contacto Rojo");
                        numberMaterial = 10;
                    }
                    if (numberMaterial == 2 && scriptPlayerSprayColor.selectedColor == 1) // si el spray es azul
                    {
                        GetComponent<Renderer>().material = White;
                        Debug.Log("Contacto Azul");
                        numberMaterial = 10;
                    }
                    if (numberMaterial == 3 && scriptPlayerSprayColor.selectedColor == 2) // si el spray es amarillo
                    {
                        GetComponent<Renderer>().material = White;
                        Debug.Log("Contacto Amarillo");
                        numberMaterial = 10;
                    }
                    if (numberMaterial == 4 && scriptPlayerSprayColor.selectedColor == 3) // si el spray es verde
                    {
                        GetComponent<Renderer>().material = White;
                        Debug.Log("Contacto Verde");
                        numberMaterial = 10;
                    }
                }
            }
        }

        if (GetComponent<Renderer>().material == White)
        {
            myCollider.enabled = true;
        }

        if (theresCollision == false)
        {
            Invoke("activateCollision", 3);
        }
    }

    IEnumerator timeDelay()
    {
        yield return new WaitForSeconds(3);
    }

    void OnCollisionEnter(Collision playerPlatform)
    {
        Debug.Log("hay colision");
        if (playerPlatform.gameObject.name == "player")
        {
            if (numberMaterial == 10)
            {
                Debug.Log("choca");
                myCollider.enabled = true;
                theresCollision = true;
            }
            else
            {
                Debug.Log("atraviesa");
                myCollider.enabled = false;
                theresCollision = false;
            }
        }
        else
        {
            myCollider.enabled = true;
        }
    }

    void activateCollision()
    {
        myCollider.enabled = true;
    }
}
