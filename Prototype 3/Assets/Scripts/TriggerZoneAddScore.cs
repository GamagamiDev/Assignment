﻿/* Colin Gamagami
 * Prototype 3
 * Increments the score when the player clears an obstacle
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddScore : MonoBehaviour
{
    private UIManager uIManager;
    private bool triggered = false;
    // Start is called before the first frame update
    void Start()
    {
        uIManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            uIManager.score++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
