using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private GameControllerScript gameController;
    [SerializeField] private string functionOnClick;
    
    public void OnMouseOver(){
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if(sprite != null){
          sprite.color = Color.cyan;
        }
    }
     
    public void OnMouseDown(){
        transform.position = new Vector3(0.3f, 0.3f, 1.0f);
    }

    public void OnMouseUp(){
        transform.position = new Vector3(0.2f, 0.2f, 1.0f);
        if(gameController != null){
          gameController.SendMessage(functionOnClick);
        }
    }

    public void OnMouseExit(){
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if(sprite != null){
           sprite.color = Color.white;
        } 
    }

}
