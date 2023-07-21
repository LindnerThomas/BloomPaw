// 'using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class CustomerManager2 : MonoBehaviour
// {

    
//     [SerializeField] CustomerObject pointA;
//     [SerializeField] CustomerObject pointB;
//     [SerializeField] CustomerObject pointC;
//     private float timeSinceLastSpawn;
//     public float customerLifetime = 5f;
//     public Transform[] spawnPoints;
//     public GameObject customerPrefab;


//     // Start is called before the first frame update
//     void Start()
//     {
//         timeSinceLastSpawn = 0f;
     
//         if (pointA.timeLeft > 0){
//             //Create Prefab with pointA Values
//         }

//          if (pointB.timeLeft > 0){
            
//         }

//          if (pointC.timeLeft > 0){
            
//         }
//     }


//     void Update(){
//         if (pointA.timeLeft <= 0 || pointA.isDone ){
//             //pointA.ResetValues();
//             GenerateRandomCustomer(0);
//         }

//         if (pointB.timeLeft <= 0 || pointB.isDone ){
//            // pointB.ResetValues();
//             GenerateRandomCustomer(1);
//         }

//         if (pointC.timeLeft <= 0 || pointC.isDone ){
//            // pointC.ResetValues();
//             GenerateRandomCustomer(2);
//         }   
//     }

//     void GenerateRandomCustomer(int spawnIndex) {
//          timeSinceLastSpawn += Time.deltaTime;
//         if (timeSinceLastSpawn >= customerLifetime)
//         {
//             SpawnRandomCustomer(spawnIndex);
//             timeSinceLastSpawn = 0f;
//         }

//         if (Input.GetMouseButtonDown(0))
//         {
//             HandleCustomerClick();
//         }
//     }

//     private void SpawnRandomCustomer(int spawnIndex)
//     {
//         if (spawnPoints.Length == 0)
//         {
//             Debug.LogError("No spawn points defined for customers.");
//             return;
//         }

//         Transform spawnPoint = spawnPoints[spawnIndex];
//         GameObject customer = Instantiate(customerPrefab, spawnPoint.position, Quaternion.identity);

//     }
    
//     private void HandleCustomerClick()
//     {
//         RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

//         if (hit.collider != null && hit.collider.CompareTag("Customer"))
//         {
//             GameObject customer = hit.collider.gameObject;
//             int[] order = GameManager.Instance.GetCustomerOrder(customer);
//             SceneManager.LoadScene(4);
//         }
//     }


// }
