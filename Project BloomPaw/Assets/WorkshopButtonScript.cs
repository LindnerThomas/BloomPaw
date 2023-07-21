using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorkshopButtonScript : MonoBehaviour
{
    [SerializeField] CustomerObject customer;

    // Update is called once per frame
    void Update()
    {
        if (customer.isAvailable == false)
        {
            this.GetComponent<Button>().enabled = true;
        }
        else if (customer.isAvailable == true) {
            this.GetComponent<Button>().enabled = false;

        }
    }
}
