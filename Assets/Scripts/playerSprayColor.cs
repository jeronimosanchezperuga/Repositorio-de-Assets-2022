using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSprayColor : MonoBehaviour
{
    public int selectedColor = 0;

    // Start is called before the first frame update
    void Start()
    {
        selectColor();
    }

    // Update is called once per frame
    void Update()
    {
        int previousSelectedColor = selectedColor;

        if(Input.GetAxis("Mouse ScrollWheel") > 0f) // mover rueda del mouse hacia arriba
        {
            if(selectedColor >= transform.childCount -1) // cuenta la cantidad de hijos que tiene el empty que contiene el script y los sprays y les asigna un numero segun el orden en el que esten
            {
                selectedColor = 0;
            }
            else
            {
                selectedColor++;
            }
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0f) // mover rueda del mouse hacia abajo
        {
            if (selectedColor <= 0)
            {
                selectedColor = transform.childCount - 1;
            }
            else
            {
                selectedColor--;
            }
        }

        if(previousSelectedColor != selectedColor)
        {
            selectColor();
        }
    }

    void selectColor() // activa el proximo spray y desactiva el que se estaba usando
    {
        int i = 0;
        foreach(Transform sprayColor in transform)
        {
            if(i == selectedColor)
            {
                sprayColor.gameObject.SetActive(true);
            }
            else
            {
                sprayColor.gameObject.SetActive(false);
            }
            i++;
        }
    }
}
