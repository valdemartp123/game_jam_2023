using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnCollision : MonoBehaviour{

bool isplayer;

void Start(){
if(gameObject==GameObject.Find("player")){
        isplayer=true;
    }else{
        isplayer=false;
    }
}

   private void OnCollisionEnter(Collision collision)
   {
   
    if (collision.gameObject.CompareTag("deadly"))
    {
        if (isplayer == true){
        SceneManager.LoadScene ("gameover");
        }else{
        Destroy(gameObject);
        ScoreManager.instance.RemovePoint();
        }
    }
   }

   }
