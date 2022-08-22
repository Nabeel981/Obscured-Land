using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ObscuredLand
{
    

    public class FlameTrigger : MonoBehaviour
    {
        public GameObject Flames;
        private void OnTriggerEnter(Collider collider)
        {
            if (collider.transform.gameObject.GetComponent<Player>())
            {
                Flames.SetActive(true);


            }
        }
    }
}
