using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;


namespace WhiteWolf {

    public class WW_NavMeshArea : MonoBehaviour {

        public bool saveBake;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        NavMeshSurface2d navMeshSurface2D;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
    
        void Start(){

            navMeshSurface2D = gameObject.AddComponent<NavMeshSurface2d>();
            gameObject.transform.eulerAngles = new Vector3( -90, 0, 0 );

            WW_BakeNavMesh bake = gameObject.AddComponent<WW_BakeNavMesh>();
            bake.StartBake( navMeshSurface2D );

            Destroy( gameObject.GetComponent<WW_NavMeshArea>() );

            if ( !saveBake ){ Destroy( gameObject.GetComponent<WW_BakeNavMesh>() ); }

        }

        void Update(){
        
        }

    }
}