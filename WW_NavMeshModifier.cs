using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

namespace WhiteWolf {

    public class WW_NavMeshModifier : MonoBehaviour {

        public bool wall;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        NavMeshModifier modifier;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        void Start() {

            modifier = gameObject.AddComponent<NavMeshModifier>();
            modifier.overrideArea = true;

            if ( wall ){ modifier.area = 1; }
            else { modifier.area = 0; }

            Destroy( gameObject.GetComponent<WW_NavMeshModifier>() );

        }

        void Update() {



        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    }

}