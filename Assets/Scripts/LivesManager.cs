using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LivesManager : MonoBehaviour
{   
    public int defaultLives;
    public int livesCounter;
    public Text livesText;

    private sceneSwitcher theSceneManager;
    // Start is called before the first frame update
    void Start()
    {
        livesCounter= defaultLives;
        theSceneManager= FindObjectOfType<sceneSwitcher>();
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "x "+livesCounter;

        if(livesCounter<1)
        {
            theSceneManager.salir();
        }
    }

    public void TakeLife()
    {
        livesCounter--;
    }

    public void addLife()
    {
        livesCounter++;
    }
}
