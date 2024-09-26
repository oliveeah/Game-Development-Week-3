//I have removed the unecessary libraries again
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{    
    //Default move value
    private float movementSpeed = 1f;
    public EnemyData enemyData; //calling the EnemyData scriptable object so we can access it in this script

    private void Start()
    {
        movementSpeed = enemyData.shipSpeed;//this takes the value of ship speed (the variable in EnemyData SO)
        // it then casts it to our movementSpeed variable
    }

    private void FixedUpdate()
    {
        //Does not execute the rest of the code if this check is true
        if (GameManager.isGameOn == false)  return;
        //To move the ship
        Movement();
    }


    void Movement()
    {
        //To store the position before the movement
        Vector2 pos = transform.position;
        //To move the ship down
        pos.y -= movementSpeed * Time.fixedDeltaTime;
        //To actually move the ship
        transform.position = pos;
    }
}
