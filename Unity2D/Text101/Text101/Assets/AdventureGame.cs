﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // user interface namespace

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent; // putting serializefield in front of variable, means now have available inside of inspector of unity
    [SerializeField] State startingState;

    State state; // representing our current state

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;

        // text will show when you click play in unity. Adding it dynamically
        textComponent.text = state.GetStateStory();  // access textCompoenent.test property, access state class and method inside of it
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
