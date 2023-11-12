using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnCollision : MonoBehaviour{

bool isplayer;

void start(){
if(gameObject==GameObject.Find("player")){
        isplayer=true;
    }else{
        isplayer=false;
    }
}

   private void OnCollisionEnter(Collision collision)
   {
   
    if (collision.collider.CompareTag("deadly"))
    {
        if (isplayer = true){
            SceneManager.LoadScene ("gameover");
        }else{
        Destroy(collision.gameObject);
        }
    }
   }

   }
