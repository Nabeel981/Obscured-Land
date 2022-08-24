using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ObscuredLand
{



    public class LaughingTrigger : MonoBehaviour
    {
        public GameObject HallLights;
        public GameObject HallMasks;
        public bool DoTask = true;
         
   
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
            if (collider.gameObject.GetComponent<Player>())
            {
                if (DoTask)
                {
                    HallMasks.SetActive(true);

                    this.GetComponent<AudioSource>().Play();
                  StartCoroutine( MakeLightsFlicker());
                    
                    DoTask = false;
                }
                else
                {
                   

                }

            }
        }
        IEnumerator MakeLightsFlicker()
        {


            HallLights.SetActive(false);
             yield return new WaitForSeconds (2);
            HallLights.SetActive(true);
            yield  return new   WaitForSeconds (2 );
            HallLights.SetActive(false);
            yield return new WaitForSeconds(2);
            HallLights.SetActive(true);
            HallMasks.SetActive(false);

        }

        
    }
}