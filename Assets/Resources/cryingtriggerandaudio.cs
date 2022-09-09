using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ObscuredLand
{


    public class cryingtriggerandaudio : MonoBehaviour
    {
        public AudioClip audioClip;
        public AudioSource audioSource;
        public GameObject doll;
        




        private void Awake()
        {
            
        }
        private void OnTriggerEnter(Collider other)
        {
            if(other.GetComponent<Player>())
            {
                doll.SetActive(true);
                audioSource.clip = audioClip;
                audioSource.Play();
                

            }else
            {
                return;
            }
        }
    }
}