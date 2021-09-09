using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthDamage : MonoBehaviour
{
   [SerializeField] Slider slider;
   [SerializeField] particles explosion;
   private int currHealth;
   private int maxhealth;
    void Start()
    {
         maxhealth = 100;
        currHealth = maxhealth;
    }

    void OnCollisionEnter(Collision col){
        if(col.collider.tag == "bullet"){
            dealdamage();
        }
         if(currHealth <= 0){
               explosion.Play();
            Destroy(this.gameObject);
        }
       
    }
    void dealdamage(){
        currHealth -= 40;
        slider.value = currHealth;
    }
   
}

