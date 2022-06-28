using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadGameScene()
    {
        SceneManager.LoadScene("gameScene");
    }

    public void loadLoseScene()
    {
        SceneManager.LoadScene("loseScene");
    }

    public void loadEndScene()
    {
        SceneManager.LoadScene("endScene");
    }

    public void loadInstructionScene()
    {
        SceneManager.LoadScene("instructionScene");
    }

    public void loadStartScene()
    {
        SceneManager.LoadScene("startScene");
    }
}
