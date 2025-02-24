using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;
	public bool is_Push = false;
    
	void Awake()
    {
		if (instance == null)
        {
			instance = this;
		}
        else
        {
			Destroy(gameObject);
		}
	}
    
    void Start() 
    {
    }

	void Update()
    {
        if (is_Push)
		{
			is_Push = false;
		}
		
	}





}