using UnityEngine;
using UnityEngine.Events;

public class EventsBehaviors : MonoBehaviour
{
	public Vector3 mousePos;
    public UnityEvent becameVisibleEvent, CollisonEnterEvent, mouseDownEvent; 
	public SpriteRenderer player;

	private void Start()
	{
		player.GetComponent<SpriteRenderer>();
	}

	public void OnBecameVisible()
	{
		becameVisibleEvent.Invoke();
	}

	public void OnMouseDown()
	{
		player.color = new Color (255, 0, 0, 255);
	}

	public void OnCollisionEnter()
	{
		Debug.Log("Enter");
	}

}
