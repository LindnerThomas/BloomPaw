// using UnityEngine;
// using System.Collections.Generic;
// using UnityEngine.SceneManagement;

// public class CustomerManager : MonoBehaviour
// {
//     public GameObject customerPrefab;
//     public Transform[] spawnPoints;
//     public float customerLifetime = 5f;
//     public int maxCustomers = 3;

//     private float timeSinceLastSpawn;
//     private int currentCustomers;

//     private void Start()
//     {
//         timeSinceLastSpawn = 0f;
//         currentCustomers = 0;


//     }

//     private void Update()
//     {
//         timeSinceLastSpawn += Time.deltaTime;

//         if (timeSinceLastSpawn >= customerLifetime && currentCustomers < maxCustomers)
//         {
//             SpawnRandomCustomer();
//             timeSinceLastSpawn = 0f;
//         }

//         if (Input.GetMouseButtonDown(0))
//         {
//             HandleCustomerClick();
//         }
//     }

//     private void SpawnRandomCustomer()
//     {
//         if (spawnPoints.Length == 0)
//         {
//             Debug.LogError("No spawn points defined for customers.");
//             return;
//         }

//         int randomSpawnIndex = Random.Range(0, spawnPoints.Length);
//         Transform spawnPoint = spawnPoints[randomSpawnIndex];

//         GameObject customer = Instantiate(customerPrefab, spawnPoint.position, Quaternion.identity);
//         Customer customerScript = customer.GetComponent<Customer>();
//         // customerScript.order = createRandomOrder();

//         GameManager.Instance.AddCustomerOrder(customer, customerScript.order);

//         currentCustomers++;
//     }
    
    

    

//     public void CustomerLeft(GameObject customer)
//     {
//         GameManager.Instance.customerOrders.Remove(customer);
//         currentCustomers--;
//     }
// }
