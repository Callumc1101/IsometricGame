using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMove : MonoBehaviour
{
    // Start is called before the first frame update
    public int sceneBuildIndex;
    void Start()
    { }


    private void OnTriggerEnter2D(Collider2D other){
        print("Trigger Entered");
        if(other.tag == "Player")
        {
            print("Switching Scene to" + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }


}


  