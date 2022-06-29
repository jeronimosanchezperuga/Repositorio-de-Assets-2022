using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 80f;

    [SerializeField] Text txtTimer;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        txtTimer.text = currentTime.ToString("0");

        if(currentTime < 0)
        {
            SceneManager.LoadScene("loseScene");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
