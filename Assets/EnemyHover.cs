// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.AI;

// public class EnemyMovement : MonoBehaviour{
//     public Transform Player;            //Reference to the player
//     int MoveSpeed = 5;                  //AI speed
//     int MaxDist = 2;                    //Action at a dsitance
//     int MinDist = 2;                    //When enemy stops
//     int MehDist = 5;                    //Sixth Sense ring
//     int MoveDist = 15;
//     private Animator animator;
//     void Start()
//     {
//         animator = GetComponent<Animator>();
//     }

//     void Update()                                                                  //This will tell the AI what to do 
//     {
//         transform.LookAt(Player);                                                  //Looks at the player

//         if (Vector3.Distance(transform.position, Player.position) <= MoveDist)      // Moves towards the player
//         {
//             animator.SetBool("isIdle", false);
//             transform.position += transform.forward * MoveSpeed * Time.deltaTime;
//             if (Vector3.Distance(transform.position, Player.position) <= MaxDist)  //If enemy gets close
//             {
//                 GameOver();                                                        //Plays GameOver screen
//             }
//             if (Vector3.Distance(transform.position, Player.position) <= MehDist)  //if enemy is inside the ring
//             {
//                 Sensor();                                                          //Calls sensor function
//                 animator.SetBool("isAttacking", true);
//             }
//             else if (Vector3.Distance(transform.position, Player.position) >= MehDist) //If enemy is away from the ring
//             {
//                 FindObjectOfType<AlertRing>().Clear();                                 //The ring turns yellow
//                 animator.SetBool("isAttacking", false);
//             }
//         }
//     }
//     void Sensor()                                                                  //ALERTS THE PLAYER
//     {
//         FindObjectOfType<AlertRing>().Sense();
//     }
//     void GameOver()
//     {
//         FindObjectOfType<GameOver>().EndGame();
//     }
// }