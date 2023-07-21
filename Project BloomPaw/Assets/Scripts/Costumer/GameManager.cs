using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{


    [SerializeField] CustomerObject pointA;
    [SerializeField] CustomerObject pointB;
    [SerializeField] CustomerObject pointC;
    private float timeSinceLastSpawn;
    public float customerLifetime = 3f;
    public float timeSinceLastCustomer = 0f;
    public float waitingTime = 5f;



    void Update(){
        NewCustomer();
        removeCustomer();
    }


    public void NewCustomer(){

        timeSinceLastCustomer += Time.deltaTime;
        int randomSpotIndex = Random.Range(1, 4);

        if (pointA.isAvailable && randomSpotIndex == 1)
        {
            newCustomerOnPointA();
        }
        if(pointB.isAvailable && randomSpotIndex == 2)
        {
            newCustomerOnPointB();
        
        }
        if(pointC.isAvailable && randomSpotIndex == 3)
        {
            newCustomerOnPointC();
        }
    }

    public void newCustomerOnPointA() {
        // waitingTime = Random.Range(3,7);
        if (timeSinceLastCustomer >= waitingTime)
        {
            pointA.flower0 = Random.Range(0, 9);
            pointA.flower1 = Random.Range(0, 9);
            pointA.flower2 = Random.Range(0, 9);
            pointA.customerSpriteID = Random.Range(0, 24);
            pointA.isAvailable = false;
            timeSinceLastCustomer = 0;
        }
        
    }

    public void newCustomerOnPointB() {
        
        // waitingTime = Random.Range(3,7);
        if (timeSinceLastCustomer >= waitingTime)
        {
            pointB.flower0 = Random.Range(0, 9);
            pointB.flower1 = Random.Range(0, 9);
            pointB.flower2 = Random.Range(0, 9);
            pointB.customerSpriteID = Random.Range(0, 24);
            pointB.isAvailable = false;
            timeSinceLastCustomer = 0;
        }
        
    }

    public void newCustomerOnPointC() {
        
        // waitingTime = Random.Range(3,7);
        if (timeSinceLastCustomer >= waitingTime)
        {
            pointC.flower0 = Random.Range(0, 9);
            pointC.flower1 = Random.Range(0, 9);
            pointC.flower2 = Random.Range(0, 9);
            pointC.customerSpriteID = Random.Range(0, 24);
            pointC.isAvailable = false;
            timeSinceLastCustomer = 0;
        }
        
    }

    public void removeCustomer(){
        if(pointA.isDone || pointA.timeLeft <= 0f){
            pointA.isAvailable = true;
            pointA.timeLeft = 30f;
            pointA.isDone = false;
        }
        if(pointB.isDone || pointB.timeLeft <= 0f){
            pointB.isAvailable = true;
            pointB.timeLeft = 30f;
            pointB.isDone = false;
        }
        if(pointC.isDone || pointC.timeLeft <= 0f){
            pointC.isAvailable = true;
            pointC.timeLeft = 30f;
            pointC.isDone = false;
        }
    }


}


    // public static GameManager Instance;

    // // Dictionary to store customer data, where the key is the customer's ID (you can use the customer GameObject instance as the key)
    // public Dictionary<GameObject, int[]> customerOrders = new Dictionary<GameObject, int[]>();

    // private void Awake()
    // {
    //     // Singleton pattern to ensure only one GameManager exists in the scene
    //     if (Instance == null)
    //         Instance = this;
    //     else if (Instance != this)
    //         Destroy(gameObject);

    //     DontDestroyOnLoad(gameObject);
    // }

    // public void AddCustomerOrder(GameObject customer, int[] order)
    // {
    //     customerOrders.Add(customer, order);
    // }

    // public int[] GetCustomerOrder(GameObject customer)
    // {
    //     int[] order;
    //     if (customerOrders.TryGetValue(customer, out order))
    //         return order;
    //     return null;
    // }


