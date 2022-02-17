﻿/*
 * Zechariah Burrus
 * Assignment 4
 * Adds to score whenever the player enters a trigger zone for the first time
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddScore : MonoBehaviour {
    private UIManager uIManager;

    private bool triggered = false;

    // Start is called before the first frame update
    void Start() {
        uIManager = GameObject.FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player") && !triggered) {
            triggered = true;
            uIManager.score++;
        }
    }
}
