using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]

public class Player : MonoBehaviour
{
    private PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        //Fetch all the components
        playerMovement = GetComponent<PlayerMovement>();
        if (playerMovement == null)
            Debug.LogError("PlayerMovement script is missing!");

        //Initialize all the scripts
        playerMovement.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement.Tick();
    }
}
