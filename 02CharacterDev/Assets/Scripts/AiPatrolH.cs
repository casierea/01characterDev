using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiPatrolH : MonoBehaviour
{
	private NavMeshAgent agent;
	
	//dynamically set distination based on starting position of AI enermies
	//public Vector3Data Destination1;
	//public Vector3Data Destination2;
	//public Vector3 Destination3;
	public List<Vector3Data> PatrolPoints = new List<Vector3Data>();

	public Vector3 Destination1;
	public Vector3 Destination2;
	private Vector3 XForce;
	// Use this for initialization
	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
		//agent.destination = Destination1.Value;
		//PatrolPoints.Add(Destination1);
		//PatrolPoints.Add(Destination2);
		agent.destination = PatrolPoints[0].Value;
		Debug.Log(agent.destination.ToString());
	}
	
	// Update is called once per frame
	void Update ()
	{
		switchDestination();
		//Debug.Log("switchDestination");
	}

	private void switchDestination()
	{
		if (Vector3.Distance(transform.position, Destination1) < 1.0f)
		{
			Debug.Log("destination1");
			
			agent.destination = Destination2;
		}
		else if (Vector3.Distance(transform.position, Destination2) < 1.0f)
		{
			agent.destination = Destination1;
		}
	}
	//on collision
	private void switchDestinationOnColl()
	{
		if (Vector3.Distance(agent.destination, PatrolPoints[0].Value) < 2.0f)
		{
			agent.destination = PatrolPoints[1].Value;
		}
		else if (Vector3.Distance(agent.destination, PatrolPoints[1].Value) < 2.0f)
		{
			agent.destination = PatrolPoints[0].Value;
		}
	}
	private void OnTriggerEnter( Collider other )
	{
		if (other.gameObject.tag == "Player")
		{
			Debug.Log("Collied with Player");
			// do damage
			//push player
			//change destination
			if (other.gameObject.GetComponent<Transform>().position.x <=
			    gameObject.GetComponent<Transform>().position.x)
			{
				XForce = new Vector3(-10, 50, 0);
			}
			else
			{
				XForce = new Vector3(10, 50, 0);
			}

			CharacterController controller = other.gameObject.GetComponent<CharacterController>();

			controller.SimpleMove(XForce * 20.0f);
		}
		switchDestinationOnColl();
	}
	
}
