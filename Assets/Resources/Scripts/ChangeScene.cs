using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace ObscuredLand
{



    public class ChangeScene : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider collider)
        {
            
            if (collider.transform.gameObject.GetComponent<Hands>())
            {
                
                SceneManager.LoadScene(0);


            }
        }

    }
}