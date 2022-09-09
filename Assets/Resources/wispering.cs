using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObscuredLand
{


    public class wispering : MonoBehaviour
    {
        public AudioClip audioClip;
        public AudioSource audioSource;
        public Light[] lights;

        private void Awake()
        {

        }
        public void Playwispers()
        {
          
                audioSource.clip = audioClip;
            audioSource.Play();

            
            
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<Player>())
            {

                this.gameObject.SetActive(false);

            }
        }

    }
}