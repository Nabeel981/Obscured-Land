using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObscuredLand
{



    public class LastDoll : MonoBehaviour
    {
        public GameObject Counter;
        public GameObject slendermen;
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
                if (Counter.GetComponent<Counter>().count == 4)
                {


                    StartCoroutine(MakeLightsFlicker());
                }
            }
        }
        IEnumerator MakeLightsFlicker()
        {
            slendermen.SetActive(true);
            
            
            slendermen.GetComponent<AudioSource>().Play();
            yield return new WaitForSeconds(2);

            yield return new WaitForSeconds(1);

            
            Counter.GetComponent<Counter>().count++;
            this.gameObject.SetActive(false);


        }
    }
}