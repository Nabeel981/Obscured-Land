using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObscuredLand
{



    public class EnableStartButtonandghost : MonoBehaviour
    {
        public GameObject StartbtnnGhost;
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
                StartbtnnGhost.SetActive(true);



            }
        }
    }
}