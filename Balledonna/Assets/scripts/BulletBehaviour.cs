using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{  [SerializeField]float DestroyAfterTime; 
[SerializeField]particles explosion;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject,DestroyAfterTime);
    }

   
   void OnCollisionEnter(Collision col){
       //if(col.collider.tag =="enemy"){
       //     Destroy(col.collider.gameObject);
            
       // }
       Debug.Log(col.collider.tag);
        explosion.Play();
        
        KillCounter.instance.killCount++;
        KillCounter.instance.UpdateKillCounterUI();
        Destroy(this.gameObject,0.1f);
        
    }
}
