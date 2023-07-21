using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteHandlerA : MonoBehaviour
{

    [SerializeField] CustomerObject pointA;
    [SerializeField] Sprite[] customerSprites;
    [SerializeField] Sprite[] flowerSprites;
    [SerializeField] GameObject[] flowers;
    [SerializeField] GameObject customerA;


    // Start is called before the first frame update
    void Awake()
    {
        customerA.SetActive(false);
    
    }

    // Update is called once per frame
    void Update()
    {

        if(pointA.isAvailable == false){
            customerA.SetActive(true);

        }

        if (pointA.isAvailable){
            customerA.SetActive(false);

        }

        SetSprites();
        
        
    }

    public void SetSprites(){
        customerA.GetComponent<SpriteRenderer>().sprite  = customerSprites[pointA.customerSpriteID];
        
        customerA.GetComponent<Customer>().flowers[0].GetComponent<SpriteRenderer>().sprite = flowerSprites[pointA.flower0];
        customerA.GetComponent<Customer>().flowers[1].GetComponent<SpriteRenderer>().sprite = flowerSprites[pointA.flower1];
        customerA.GetComponent<Customer>().flowers[2].GetComponent<SpriteRenderer>().sprite = flowerSprites[pointA.flower2];
        

    }
}
