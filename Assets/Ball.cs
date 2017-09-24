using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Ball : MonoBehaviour {

	public float speed = 5f;

	public Text scoreText;

	private int points1;
	private int points2;

	// Use this for initialization
	void Start () {
		points1 = 0;
		points2 = 0;


		SetScoreText ();

		float sx = Random.Range (0, 2) == 0 ? -1 : 1;
		float sy = Random.Range (0, 2) == 0 ? -1 : 1;

		GetComponent<Rigidbody> ().velocity = new Vector3 (speed * sx, speed * sy, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (transform.position.x < -10 || transform.position.x > 10) {
			if (transform.position.x < -10) {
				points1++;
			} else {
				points2++;
			}

			SetScoreText ();
			transform.position = new Vector3 (0f, 0f, 0f);

		}
	}

	void SetScoreText () {
		scoreText.text = points2.ToString() + "|" + points1.ToString();
	}
}
