using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public GameObject obstacklePrefab;
    private Vector3 spawnPos = new Vector3 (25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController PlayerControllerScript;
    // Start is called before the first frame update
    void Start () {

        InvokeRepeating ("SpawnObstackle", startDelay, repeatRate);
        PlayerControllerScript =
            GameObject.Find ("Player").GetComponent<PlayerController> ();
    }

    void SpawnObstackle () {
        if (PlayerControllerScript.gameOver == false) {

            Instantiate (obstacklePrefab, spawnPos, obstacklePrefab.transform.rotation);
        }
    }
    // Update is called once per frame
    void Update () {

    }
}