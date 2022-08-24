using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObscuredLand
{
    public class Lookbehindyou : MonoBehaviour
    {
        public GameObject Counter;
        public GameObject demonReveal;
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

                StartCoroutine(MakeLightsFlicker());

            }
        }
        IEnumerator MakeLightsFlicker()
        {

            this.gameObject.GetComponent<AudioSource>().Play();
            demonReveal.SetActive(true);
            yield return new WaitForSeconds(2);
           
            yield return new WaitForSeconds(1);
           
            demonReveal.SetActive(false);
            Counter.GetComponent<Counter>().count++;
            this.gameObject.SetActive(false);


        }
    }
}