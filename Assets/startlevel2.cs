using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace ObscuredLand
{


    public class startlevel2 : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<Hands>())
            {
                SceneManager.LoadScene(2);

            }
        }
    }
}