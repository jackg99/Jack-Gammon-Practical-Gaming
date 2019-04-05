using UnityEngine;
using System.Collections;
public class EnemyAi : MonoBehaviour
{
    void Start()
    {

    }

    public Transform Player;
    public float Attack_range = 1.5f;
    public float Chase_Range = 20;
    public float Distance = 10;
    public float RotSpeed = 3; 
    public float MoveSpeed = 5; 
    void Update()
    {

        // The Distance Between the Player and Enemy
        Distance = (Player.transform.position - transform.position).magnitude;

        // when the target gets close to the player
        if (Distance <= Chase_Range && Distance > Attack_range)
        {
            Vector3 Direction = Player.position - transform.position;
            Direction.y = 0; //target won't rotate on y-axis

            // rotate the target toward the player
            transform.rotation = Quaternion.Slerp(transform.rotation,
                                                  Quaternion.LookRotation(Direction), RotSpeed * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;


        }

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, Attack_range);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, Chase_Range);
    }

}