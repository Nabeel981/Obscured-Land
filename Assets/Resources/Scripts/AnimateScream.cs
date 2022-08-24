using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObscuredLand
{


    public class AnimateScream : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            this.gameObject.GetComponent<Animation>().Play();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}