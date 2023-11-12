using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnCollision : MonoBehaviour{

bool isplayer;
public AudioSource source;
public AudioClip clip;
void Start(){
if(gameObject==GameObject.Find("player")){
        isplayer=true;
    }else{
        isplayer=false;
    }
    source=GetComponent<AudioSource>();
}

   private void OnCollisionEnter(Collision collision)
   {
   
    if (collision.gameObject.tag=="deadly")
    {
        Debug.Log("spil lyd");
        if (isplayer == true){
        SceneManager.LoadScene ("gameover");
        }else{
        source.Play();
        //source.PlayOneShot(clip);
        Destroy(gameObject,1.5f);
        ScoreManager.instance.RemovePoint();
        }
    }
   }

   void Update(){
    if(transform.position.y<-10){
        if (isplayer == true){
        SceneManager.LoadScene ("gameover");
        }else{
        source.Play();
        //source.PlayOneShot(clip);
        Destroy(gameObject,1.5f);
        ScoreManager.instance.RemovePoint();
        }
    }
   }

   }
