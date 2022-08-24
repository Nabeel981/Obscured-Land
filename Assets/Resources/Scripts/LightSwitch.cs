using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObscuredLand
{


    public class LightSwitch : MonoBehaviour
    {
       AudioSource LightsOn;
       AudioSource LightsOff;
        public AudioClip LightOnAudio;
        public AudioClip LightOffAudio;
       
        public   ObjectType objectType = ObjectType.LightSwitch;
       public  Material LightOnMaterial;
        public Material LightOffMaterial;
        public List<GameObject> Lights;
        public bool LightsAreOn = true;

        private void Awake()
        {
            MakeTwoSources();
            LightsOn.clip = LightOnAudio;
            LightsOff.clip = LightOffAudio;
            AudioSource audioSource = this.transform.gameObject.GetComponent<AudioSource>();
        }
        private void OnTriggerEnter(Collider collider)
        {
            if (LightsAreOn)
            {



                LightsOff.Play();
                foreach (GameObject gameObject in Lights)
                {
                    gameObject.GetComponent<Light>().enabled = false;
                    gameObject.GetComponent<MeshRenderer>().material = LightOffMaterial;
                }
                LightsAreOn = false;

                


            }
            else
            {
                LightsOn.Play();
                foreach (GameObject gameObject in Lights)
                {
                    gameObject.GetComponent<Light>().enabled = true;
                    gameObject.GetComponent<MeshRenderer>().material = LightOnMaterial;;
                }
                LightsAreOn = true;
                
               
            }
        }
        public void MakeTwoSources()
        {
            LightsOn = this.gameObject.AddComponent<AudioSource>();
            LightsOff = this.gameObject.AddComponent<AudioSource>();

        }
    }
}