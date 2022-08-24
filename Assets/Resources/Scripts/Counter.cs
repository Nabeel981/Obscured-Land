using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObscuredLand
{
    


    public class Counter : MonoBehaviour
    {
        public int count;
      public  GameObject Door;
     public   GameObject finalLight;
        // Start is called before the first frame update
        void Start()
        {

        }
        private void Awake()
        {
            count = 0;
        }
        // Update is called once per frame
        void Update()
        {
            if(count== 5)
            {
                Door.GetComponent<BoxCollider>().enabled = true;
                finalLight.SetActive(true);


            }

        }
    }
}