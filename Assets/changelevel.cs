using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ObscuredLand
{



    public class changelevel : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<Player>())
            {
                
                SceneManager.LoadScene(0);
                

            }
        }
    }
}