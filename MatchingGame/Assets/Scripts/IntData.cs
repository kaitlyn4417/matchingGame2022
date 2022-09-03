using UnityEngine;

[CreateAssetMenu]

public class IntData : ScriptableObject
{
	public int value;
	public int num = 1;

	public void UpdateValue(int num)
	{
		value -= num;
	}
	
}
