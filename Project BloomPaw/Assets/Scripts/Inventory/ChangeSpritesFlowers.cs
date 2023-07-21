using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSpritesFlowers : MonoBehaviour
{
    [SerializeField] InventoryItem inventoryItem;
    [SerializeField] InventoryHandler inventoryHandler;
    public Sprite sp1, sp2;


    // Change the Sprite of the Inventory Item when it is 0 and when it is 1;
    void Update()
    {
         if(inventoryItem.flowerCount == 0){
            GetComponent<SpriteRenderer>().sprite = sp2;
        }else if(inventoryItem.flowerCount >= 1) {
            GetComponent<SpriteRenderer>().sprite = sp1;
        }
    }
}

