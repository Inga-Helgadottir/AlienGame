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
    // Start is called before the first frame update
    void Start(){
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update(){
        navMeshAgent.SetDestination(Player.position);
    }
    
    void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            gameManager.EndGame();
        }
    }
}

/* floating object
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour{
    private NavMeshAgent navMeshAgent;
    public Transform Player;
    public float maxSpeed = 10f;
    public float distanceFromGround = 20f;
    // Start is called before the first frame update
    void Start(){
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update(){
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 newPos = transform.position;
        newPos += transform.forward * hor * maxSpeed * Time.deltaTime;
        newPos += transform.right * ver * maxSpeed * Time.deltaTime;
        transform.position = newPos;

        RaycastHit hit;

        if(Physics.Raycast(transform.position, Vector3.down, out hit)){
            newPos.y = (hit.point + Vector3.up * distanceFromGround).y;
        }
        navMeshAgent.SetDestination(Player.position);
    }
}

*/

/*  enemy follows player
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour{
    private NavMeshAgent navMeshAgent;
    public Transform Player;
    // Start is called before the first frame update
    void Start(){
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update(){
        navMeshAgent.SetDestination(Player.position);
    }
}

*/