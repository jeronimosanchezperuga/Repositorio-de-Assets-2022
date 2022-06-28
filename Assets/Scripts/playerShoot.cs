using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerShoot : MonoBehaviour
{
    public GameObject myCamera;
    public GameObject crosshair;

    public AudioSource source;
    public AudioClip spraySound;
    public AudioClip backgroundMusic;

    [SerializeField] private Image Crosshair;

    public playerSprayColor scriptPlayerSprayColor; // vincular scripts

    public paintPlatform scriptPaintPlatform;

    public randomizer scriptRandomizer;

    public GameObject myPlatform;

    public RaycastHit hit;

    public bool isHitting;

    // Start is called before the first frame update
    void Start()
    {
        source.PlayOneShot(backgroundMusic);

        Crosshair.color = new Color(1, 1, 1, 0.75f); // crosshair blanco

        scriptPlayerSprayColor = FindObjectOfType<playerSprayColor>(); // vincular scripts
        
        scriptPaintPlatform = FindObjectOfType<paintPlatform>();

        scriptRandomizer = FindObjectOfType<randomizer>();
    }

    // Update is called once per frame
    void Update()
    {
        string gameObjectShot;

        isHitting = Physics.Raycast(myCamera.transform.position, myCamera.transform.forward, out hit, 30f);

        if (isHitting)
        {
            Vector3 shotPosition = hit.point;
            float shootDistance = hit.distance;
            gameObjectShot = hit.collider.gameObject.name;

            //Debug.Log(gameObjectShot + " - " + scriptPaintPlatform.numberMaterial);

            if (hit.transform.gameObject.CompareTag("tagPlatform"))
            {
                Crosshair.color = new Color(1, 0, 0, 0.75f); // crosshair rojo

                if (Input.GetMouseButtonDown(0))
                {
                    source.PlayOneShot(spraySound);
                }
            }
            else
            {
                Crosshair.color = new Color(1, 1, 1, 0.75f); // crosshair blanco
            }
        }
        else
        {
            Crosshair.color = new Color(1, 1, 1, 0.75f);
        }
    }
}
