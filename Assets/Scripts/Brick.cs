using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{

    [SerializeField] int health = 1;

      private LevelLoader levelLoader ; 
      private LevelController levelController ; 


    void Awake(){
        // levelLoader = FindObjectOfType<LevelLoader>();
         levelController = FindObjectOfType<LevelController>();

    }
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = Color.yellow;
    }

    // Update is called once per frame
       private void OnCollisionEnter2D(Collision2D collision)
        {
           // FindObjectOfType<LevelController>().IncreaseScore();
            //Destroy(gameObject);
            DecreaseHealth();
        }

        private void DecreaseHealth()
        {
        health--;
        if(health <= 0)
        {
           levelLoader = FindObjectOfType<LevelLoader>();
         levelLoader.DeductBrick();
        Destroy(gameObject);
        }
        else
        {
        GetComponent<SpriteRenderer>().color = Color.red;
        }
        }

 
}
