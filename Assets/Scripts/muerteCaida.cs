using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class muerteCaida : MonoBehaviour
{
   private Animator anim;
   private Text vidasObj; 
  // private int vidas=3;
    
    public void OnCollisionEnter2D(Collision2D other)
    {
       anim = GameObject.FindWithTag("imagen2").GetComponent<Animator>();
       // canvas = GameObject.FindGameObjectWithTag("myCanvas").GetComponent<Canvas>();
       // Debug.Log("colision");
       if(other.transform.tag == "player")
       {
           //Debug.Log(anim);
           anim.Play("fadeIn");
           
           
          /*  vidasObj = GameObject.FindWithTag("NumeroVidas").GetComponent<Text>();
           // Debug.Log(vidasObj.text);
            vidas= int.Parse(vidasObj.text) ;
            Debug.Log(vidas);
            //Debug.Log(vidas);
           // vidasObj.text = (vidas-1).ToString();
            //Debug.Log(vidas);*/
            
           StartCoroutine(LoadNextScene());
           Destroy(other.gameObject);
           
       } 
    }


    

    IEnumerator LoadNextScene()
    {
     //   Debug.Log(vidas);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }
}
