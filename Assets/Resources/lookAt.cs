using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAt : MonoBehaviour
{
    public GameObject player;
    private void Update()
    {
        this.transform.LookAt(player.transform);
    }
}
