using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObscuredLand
{



    public class startwispering : MonoBehaviour
    {
        public GameObject wisperinG;
        public GameObject disable;
        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<Player>())
            {
                wisperinG.GetComponent<wispering>().Playwispers();
                disable.SetActive(false);

            }
        }
    }
}