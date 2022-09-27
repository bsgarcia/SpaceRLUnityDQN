using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MLAgents;
using UnityEngine.SceneManagement;


public class SpaceAcademy : Academy
{
    int totalScore = 0;
    public GameObject[] agents;
    public SpaceAgent agent;
    int resetCount = 0;
    bool startGame = false;
    private GameController gameController;

    public override void AcademyReset()
    {   
        // if (resetCount > 0) {
        //     for (int i = 0; i < gameController.options.Count; i++) {
        //         Destroy(gameController.options[i]);
        //     }
        //     gameController.options.Clear();
        // }

        agents = GameObject.FindGameObjectsWithTag("agent");
        agent = GameObject.FindWithTag("agent").GetComponent<SpaceAgent>();
        gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
        gameController.Run();
        Debug.Log("SpaceAcademy.cs: Reset Env...");
        resetCount++;

    }

    public override void AcademyStep()
    {
        //scoreText.text = string.Format(@"Score: {0}", totalScore);
    }

    public override void EnvironmentStep () {
        
        // if (gameController.optionsOnScreen) {
        //     agent.SetTextObs("ready");
        // } else {
        //     agent.SetTextObs("ready");
        // }

        // if (startGame && gameController.optionsOnScreen) {
        base.EnvironmentStep();
        // }
    }
}
