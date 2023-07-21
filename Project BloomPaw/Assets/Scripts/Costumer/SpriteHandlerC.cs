using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteHandlerC : MonoBehaviour
{
    [SerializeField] CustomerObject pointC;
    [SerializeField] Sprite[] customerSprites;
    [SerializeField] Sprite[] flowerSprites;
    [SerializeField] GameObject[] flowers;
    [SerializeField] GameObject customerC;


    // Start is called before the first frame update
    void Awake()
    {
        customerC.SetActive(false);
    
    }

    // Update is called once per frame
    void Update()
    {

        if(pointC.isAvailable == false){
            customerC.SetActive(true);

        }

        if (pointC.isAvailable){
            customerC.SetActive(false);

        }

        SetSprites();
        
        
    }

    public void SetSprites(){
        customerC.GetComponent<SpriteRenderer>().sprite  = customerSprites[pointC.customerSpriteID];
        
        customerC.GetComponent<Customer>().flowers[0].GetComponent<SpriteRenderer>().sprite = flowerSprites[pointC.flower0];
        customerC.GetComponent<Customer>().flowers[1].GetComponent<SpriteRenderer>().sprite = flowerSprites[pointC.flower1];
        customerC.GetComponent<Customer>().flowers[2].GetComponent<SpriteRenderer>().sprite = flowerSprites[pointC.flower2];
        

    }
}
