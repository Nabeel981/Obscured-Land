using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace ObscuredLand
{

    public class StartGame : MonoBehaviour
    {
       
        private void OnTriggerEnter(Collider collider)
        {
            if (collider.transform.gameObject.GetComponent<Hands>())
            {
                SceneManager.LoadScene(1);
                


            }
        }
    }
}