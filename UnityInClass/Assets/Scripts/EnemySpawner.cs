using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
	
	public float spawnChance = 0.01f;
	public Vector3 spawnArea = new Vector3(9f, 5f, 9f);
	public GameObject enemyPrefab;
	
	
	//public bool derp;
	//public Vector3 thevec;
	//public Color color;
	//public AnimationCurve curve;
	//public Gradient gradient;
	
	// Use this for initialization
	//void Start () {
	//
	//}
	
	// Update is called once per frame
	void Update () {
		//Randomly spawn robot enemies
		if(Random.value < spawnChance){
			//choose position in a volume centered around local origin
			Vector3 pos = new Vector3(Random.Range(-0.5f, 0.5f),Random.Range(-0.5f, 0.5f),Random.Range(-0.5f, 0.5f));
			pos.Scale (spawnArea);
			
			//spawn!
			GameObject go = (GameObject)Instantiate (enemyPrefab);
			go.transform.position = pos + transform.position;
			
			//parent newly instantiated thing to "me" (spawnPoint)
			go.transform.parent = transform;
		}
	}
}
