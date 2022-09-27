using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

public class SpaceAgent : Agent
{
    public GameObject myAcademyObj;
    SpaceAcademy myAcademy;
    public GameObject area;

    public bool ready2 = false;
    //BananaArea myArea;
    bool frozen;
    bool poisioned;
    bool satiated;
    bool shoot;
    float frozenTime;
    float effectTime;

    PlayerController playerController;

    Rigidbody agentRb;
    private int bananas;

    // Speed of agent rotation.
    public float turnSpeed = 300;

    // Speed of agent movement.
    public float moveSpeed = 2;
    public Material normalMaterial;
    public Material badMaterial;
    public Material goodMaterial;
    public Material frozenMaterial;
    public GameObject myLaser;
    public bool contribute;
    private RayPerception rayPer;
    public bool useVectorObs;

    // void Update () {

    //     SetReady(ready2);
        
    // }

    public override void InitializeAgent()
    {   
        playerController = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
        base.InitializeAgent();
        agentRb = playerController.GetRigidbody();
        // Monitor.verticalOffset = 1f;
        // myArea = area.GetComponent<BananaArea>();
        rayPer = playerController.GetComponent<RayPerception>();
        myAcademy = myAcademyObj.GetComponent<SpaceAcademy>();
        base.SetTextObs("ready");
        // CollectObservations();
    }

    public override void CollectObservations()
    {
        if (useVectorObs)
        {
            float rayDistance = 25f;
            float[] rayAngles = { 20f, 90f, 160f, 45f, 135f, 70f, 110f };
            string[] detectableObjects = { "Opt1", "Opt2"};
            AddVectorObs(rayPer.Perceive(rayDistance, rayAngles, detectableObjects, 0f, 0f));
            // Vector3 localVelocity = transform.InverseTransformDirection(agentRb.velocity);
            // AddVectorObs(localVelocity.x);
            // AddVectorObs(localVelocity.z);

            Vector3 localposition = agentRb.position;
            AddVectorObs(localposition.x);
            AddVectorObs(localposition.y);
            // AddVectorObs(System.Convert.ToInt32(frozen));
            // AddVectorObs(System.Convert.ToInt32(shoot));
        }
    }

    public Color32 ToColor(int hexVal)
    {
        byte r = (byte)((hexVal >> 16) & 0xFF);
        byte g = (byte)((hexVal >> 8) & 0xFF);
        byte b = (byte)(hexVal & 0xFF);
        return new Color32(r, g, b, 255);
    }

    public void MoveAgent(float[] act)
    {

        Debug.Log("SpaceAgent.cs: Selected action = " + act[0]);
       
        switch ((int)act[0])
        {
            case 0:
                // playerController.MoveHorizontal(1.0f);
                AddReward(0.5f);
                return;
                //dirToGo = transform.forward;
                break;
            case 1:
                AddReward(-0.5f);
                playerController.MoveHorizontal(-0.5f);
                break;
            case 2:
                AddReward(-0.5f);
                playerController.MoveHorizontal(0.5f);
                break;
            case 3:
                AddReward(-0.5f);
                // playerController.MoveHorizontal(1.0f);
                playerController.Shoot();
                break;
        }
    
    }

    public override void AgentAction(float[] vectorAction, string textAction)
    {
        MoveAgent(vectorAction);
    }

    public override void AgentReset()
    {
        // Unfreeze();
        // Unpoison();
        // Unsatiate();
        // shoot = false;
        // agentRb.velocity = Vector3.zero;
        // bananas = 0;
        // myLaser.transform.localScale = new Vector3(0f, 0f, 0f);
        // transform.position = new Vector3(Random.Range(-myArea.range, myArea.range),
        //                                  2f, Random.Range(-myArea.range, myArea.range))
        //     + area.transform.position;
        // transform.rotation = Quaternion.Euler(new Vector3(0f, Random.Range(0, 360)));
    }

    // void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.CompareTag("banana"))
    //     {
    //         Satiate();
    //         collision.gameObject.GetComponent<BananaLogic>().OnEaten();
    //         AddReward(1f);
    //         bananas += 1;
    //         if (contribute)
    //         {
    //             myAcademy.totalScore += 1;
    //         }
    //     }
    //     if (collision.gameObject.CompareTag("badBanana"))
    //     {
    //         Poison();
    //         collision.gameObject.GetComponent<BananaLogic>().OnEaten();

    //         AddReward(-1f);
    //         if (contribute)
    //         {
    //             myAcademy.totalScore -= 1;
    //         }
    //     }
    // }

    public override void AgentOnDone()
    {

    }
}
