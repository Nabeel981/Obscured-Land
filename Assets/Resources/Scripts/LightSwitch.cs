using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObscuredLand
{


    public class LightSwitch : MonoBehaviour
    {
      public   ObjectType objectType = ObjectType.LightSwitch;
       public  Material LightOnMaterial;
        public Material LightOffMaterial;
        public List<GameObject> Lights;
        public bool LightsAreOn = true;
        private void OnTriggerEnter(Collider collider)
        {
            if (LightsAreOn)
            {



                foreach (GameObject gameObject in Lights)
                {
                    gameObject.GetComponent<Light>().enabled = false;
                    gameObject.GetComponent<MeshRenderer>().material = LightOffMaterial;
                }
                LightsAreOn = false;
            }
            else
            {
                foreach (GameObject gameObject in Lights)
                {
                    gameObject.GetComponent<Light>().enabled = true;
                    gameObject.GetComponent<MeshRenderer>().material = LightOnMaterial;;
                }
                LightsAreOn = true;
            }
        }
    }
}