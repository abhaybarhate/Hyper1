using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour{

    [SerializeField] float playerSpeed = 5f;
    
    float playerEnergy;
    NavMeshAgent playerAgent;
    // Start is called before the first frame update
    void Start(){
        
        playerAgent = GetComponent<NavMeshAgent>();
        playerEnergy = playerSpeed * 100f;
    }

    // Update is called once per frame
    void Update(){

        MovePlayer();
        
    }

    void MovePlayer() {
        RaycastHit hitInfo;
        if(Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            if(Physics.Raycast(ray, out hitInfo)) {
                playerAgent.SetDestination(hitInfo.point);
                playerAgent.speed = playerSpeed;
                playerAgent.angularSpeed = playerEnergy;
            }
            
        }
    }

}
