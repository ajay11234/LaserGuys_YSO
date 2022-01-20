using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_enemies : MonoBehaviour
{
    // Start is called before the first frame update
    public spawn_enemies spawn;
    void Start()
    {
        spawn.start_spawn();
    }

   
}
