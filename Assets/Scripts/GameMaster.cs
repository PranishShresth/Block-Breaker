using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    [SerializeField] int noOfBlocksBroken;

    public void CounttheBlocks()
    {
        noOfBlocksBroken++;
    }

    public void BlockDestroyed()
    {
        noOfBlocksBroken--;
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
    }
}
