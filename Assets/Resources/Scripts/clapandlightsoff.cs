using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObscuredLand
{
    public class clapandlightsoff : MonoBehaviour
    {
        AudioSource clapping;
        AudioSource breathing;
        public AudioClip clappingclip;
        public AudioClip breathingclip;
        public   GameObject Lights;
        public GameObject Counter;
        
        
        // Start is called before the first frame update
        void Start()
        {
            MakeTwoSources();
            clapping.clip = clappingclip;
            breathing.clip = breathingclip;

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

            breathing.Play();
            Lights.SetActive(false);
            yield return new WaitForSeconds(3);
            Lights.SetActive(true);
            breathing.Stop();
            yield return new WaitForSeconds(1);
            Lights.SetActive(true);
            clapping.Play();
            Counter.GetComponent<Counter>().count++;
            yield return new WaitForSeconds(1);
            this.gameObject.SetActive(false);

        }
        public void MakeTwoSources()
        {
            clapping = this.gameObject.AddComponent<AudioSource>();
            breathing = this.gameObject.AddComponent<AudioSource>();

        }
    }
}