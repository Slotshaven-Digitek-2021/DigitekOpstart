using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Digiteknik {
	public class HitMe : MonoBehaviour {

        public int pointValue = 1;

        private GameControl script;
        private KegleSpawner ks;

        void Start(){
            script = FindObjectOfType<GameControl>();
            ks = FindObjectOfType<KegleSpawner>();
        }

        void OnCollisionEnter(Collision other){
            print ("Noget ramte mig: " + other.gameObject.tag);
            if (other.gameObject.CompareTag ("Player")) {
                Explode ();
            }
        }

        void Explode(){
            print ("AAARGHHH! - Jeg døøør, siger keglen");
            //gameObject.GetComponent<Renderer>().enabled = false;
            script.AddScore(pointValue);

            float spawnTid = (float)Random.Range(1.5f,3.0f);
            print ("SpawnTid er: " + spawnTid);
            ks.NyKegle(spawnTid);
            Destroy(gameObject);
        }


    }
}

/*


*/