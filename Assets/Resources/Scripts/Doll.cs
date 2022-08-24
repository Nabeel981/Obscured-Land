using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObscuredLand
{



    public class Doll : MonoBehaviour
    {
        public GameObject Counter;
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
            if (collider.gameObject.GetComponent<Hands>())
            {
                Counter.GetComponent<Counter>().count++;
                this.gameObject.SetActive(false);
                
            }
        }
        IEnumerator MakeLightsFlicker()
        {

            
            yield return new WaitForSeconds(1);
            
            
            
            

        }

    }



}