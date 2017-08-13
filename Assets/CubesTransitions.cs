using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesTransitions : MonoBehaviour {
	
	[SerializeField]
	GameObject redCube;
	[SerializeField]
	GameObject blueCube;
	[SerializeField]
	GameObject greenCube;

	/*Transform redCubeInitialTrans;
	Transform blueCubeInitialTrans;
	Transform greenCubeInitialTrans;*/

	Quaternion redCubeInitialRotation;
	Quaternion blueCubeInitialRotation;
	Quaternion greenCubeInitialRotation;

	void Start () {
		/*redCubeInitialTrans = redCube.transform;
		blueCubeInitialTrans = blueCube.transform;
		greenCubeInitialTrans = greenCube.transform;*/

		redCubeInitialRotation = redCube.transform.rotation;
		blueCubeInitialRotation = blueCube.transform.rotation;
		greenCubeInitialRotation = greenCube.transform.rotation;
	}

	void Update () {
		
		switch (Input.inputString) {
		case "1":
			redCube.transform.localScale += new Vector3(Random.Range(-25.0f,25.0f),Random.Range(-15.0f,65.0f),Random.Range(-75.0f,125.0f))*Time.deltaTime/50;
			blueCube.transform.localScale += new Vector3(Random.Range(-25.0f,65.0f),Random.Range(-65.0f,25.0f),Random.Range(-5.0f,45.0f))*Time.deltaTime/20;
			greenCube.transform.localScale += new Vector3(Random.Range(-75.0f,125.0f),Random.Range(-15.0f,65.0f),Random.Range(-65.0f,25.0f))*Time.deltaTime/30;
			break;

			case "2":
			redCube.transform.Rotate (new Vector3 (Random.Range(-25.0f,65.0f),Random.Range(-65.0f,25.0f),Random.Range(-5.0f,45.0f)) * Time.deltaTime * 2.0f);
			blueCube.transform.Rotate (new Vector3 (Random.Range(-75.0f,125.0f),Random.Range(-15.0f,65.0f),Random.Range(-65.0f,25.0f)) * Time.deltaTime * 1.0f);
			greenCube.transform.Rotate (new Vector3 (Random.Range(-25.0f,25.0f),Random.Range(-15.0f,65.0f),Random.Range(-75.0f,125.0f)) * Time.deltaTime * 3.0f);
			break;

		case "3":
			/*redCube.transform.rotation = redCubeInitialTrans.rotation;
			blueCube.transform.rotation = blueCubeInitialTrans.rotation;
			greenCube.transform.rotation = greenCubeInitialTrans.rotation;

			redCube.transform.localScale = redCubeInitialTrans.localScale;
			blueCube.transform.localScale = blueCubeInitialTrans.localScale;
			greenCube.transform.localScale = greenCubeInitialTrans.localScale;*/

			redCube.transform.rotation = redCubeInitialRotation;
			blueCube.transform.rotation = blueCubeInitialRotation;
			greenCube.transform.rotation = greenCubeInitialRotation;

			redCube.transform.localScale = new Vector3 (1.0f,1.0f,1.0f);
			blueCube.transform.localScale = new Vector3 (1.0f,1.0f,1.0f);
			greenCube.transform.localScale = new Vector3 (1.0f,1.0f,1.0f);
			break;
		}
		
	}
}
