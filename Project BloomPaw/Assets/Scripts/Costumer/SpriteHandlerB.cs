using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteHandlerB : MonoBehaviour
{

    [SerializeField] CustomerObject pointB;
    [SerializeField] Sprite[] customerSprites;
    [SerializeField] Sprite[] flowerSprites;
    [SerializeField] GameObject[] flowers;
    [SerializeField] GameObject customerB;


    // Start is called before the first frame update
    void Awake()
    {
        customerB.SetActive(false);
    
    }

    // Update is called once per frame
    void Update()
    {

        if(pointB.isAvailable == false){
            customerB.SetActive(true);

        }

        if (pointB.isAvailable){
            customerB.SetActive(false);

        }

        SetSprites();
        
        
    }

    public void SetSprites(){
        customerB.GetComponent<SpriteRenderer>().sprite  = customerSprites[pointB.customerSpriteID];
        
        customerB.GetComponent<Customer>().flowers[0].GetComponent<SpriteRenderer>().sprite = flowerSprites[pointB.flower0];
        customerB.GetComponent<Customer>().flowers[1].GetComponent<SpriteRenderer>().sprite = flowerSprites[pointB.flower1];
        customerB.GetComponent<Customer>().flowers[2].GetComponent<SpriteRenderer>().sprite = flowerSprites[pointB.flower2];
        

    }
}
