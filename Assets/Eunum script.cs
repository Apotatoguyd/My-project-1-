using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]
public class Eunumscript : MonoBehaviour
{
    [SerializeField] public Stuff stuff;




    public enum Stuff
    {
        Level1,
        Level2,
        Level3,
        

        
    }

    void bruh(Stuff stuff)
    {

        switch (stuff)
        {
            case Stuff.Level1:
        
                Debug.Log("brug");
                SceneManager.LoadScene("SampleScene");
                break;

            case Stuff.Level2:
        
                Debug.Log("et");
                SceneManager.LoadScene("Bro");
                break; 
            case Stuff.Level3:
                
                Debug.Log("lol");
                SceneManager.LoadScene("iamlazy");
                break;

        }
    }




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       


        if(Input.GetKeyDown(KeyCode.W)) 
        {
         
          bruh(Stuff.Level1);
            stuff = Stuff.Level1;
           
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            
            bruh(Stuff.Level2);
            stuff = Stuff.Level2;
         
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
           
            bruh(Stuff.Level3);
            stuff = Stuff.Level3;
          
        }

    }


}
