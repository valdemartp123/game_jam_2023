using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
void start(){
    bool isplayer = false;
}
   private void OnCollisionEnter(Collision collision)
   {
    if(gameObject==GameObject.Find("player")){
        isplayer=true;
    }else{
        isplayer=false;
    }
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
