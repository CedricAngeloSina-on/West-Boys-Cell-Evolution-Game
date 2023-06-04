 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 
 public class RandomBackground : MonoBehaviour {
 
     public Sprite[] Backgrounds; //t$$anonymous$$s is an array of type sprite
 
     public SpriteRenderer Render; //t$$anonymous$$s is a variable of type sprite renderer
 
     // Use t$$anonymous$$s for initialization
     void Start () 
     {
        Render = GetComponent<SpriteRenderer>(); 
        /*assigning the Render to the object's SpriteRender, t$$anonymous$$s will allow us to access the image from 
        code*/
        Render.sprite = Backgrounds[Random.Range(0, Backgrounds.Length)]; 
        /*t$$anonymous$$s will change the current sprite of the sprite renderer to a random sprite that was chosen 
        randomly from the array of backgrounds */
    }
     // Update is called once per frame
     void Update () {
 
     }
 }
