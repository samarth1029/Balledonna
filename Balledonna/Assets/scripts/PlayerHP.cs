using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHP : MonoBehaviour
{
    [SerializeField] Slider Playerhealth;
     private int maxmhealth;
     private int hp;
    void Start()
    {
        maxmhealth = 100;
        hp = maxmhealth;
    }
    void OnCollisionEnter(Collision col){
        if(col.collider.tag == "enemy"){
            takedamage();
        }
         if(hp<=0){
            Time.timeScale = 0;
        }
    }
    void takedamage(){
        hp -= 14;
        Playerhealth.value = hp;
    }
}
