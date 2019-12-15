using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // user interface namespace

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent; // putting serializefield in front of variable, means now have available inside of inspector of unity

    // Start is called before the first frame update
    void Start()
    {
        // text will show when you click play in unity. Adding it dynamically
        textComponent.text = ("Once upon a time long long ago, there was an army of soldiers doing everything they can to stop the war. " +
            "THe war that would ultimately end humanity. The leader made a concious decision. Although the soldiers were out numbered. " +
            "The leader burned the boat, so that there was no way back. The only way back was to win the war. Therefore, the soldiers had to fight for there life. " +
            "After a long battle, they won that war. They kept going in hopes to see their families again and to this day 2019." +
            " We all perserve in peace because of that war.");   // access textCompoenent.test property
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
