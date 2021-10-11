using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

namespace WhiteWolf {

    public class WW_BakeNavMesh : MonoBehaviour {

        void Start() {



        }

        void Update() {



        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public void StartBake( NavMeshSurface2d surface2D ){

            surface2D.collectObjects = CollectObjects2d.Children;
            surface2D.useGeometry = NavMeshCollectGeometry.PhysicsColliders;
            surface2D.BuildNavMeshAsync();

        }

        public void Bake( NavMeshSurface2d surface2D ) => surface2D.BuildNavMeshAsync();

    }

}