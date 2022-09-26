using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour{
    private NavMeshAgent navMeshAgent;
    public Transform Player;
    [SerializeField] GameManager gameManager;
    
    void awake(){
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    
    void Start(){
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update(){
        navMeshAgent.SetDestination(Player.position);
    }
}