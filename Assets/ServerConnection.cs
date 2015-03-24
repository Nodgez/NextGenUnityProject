using UnityEngine;
using System.Collections;
using NextGenServer;
using UnityEngine.UI;

public class ServerConnection : MonoBehaviour {

	Connection connection = new Connection();
	public Text useraname;
	public Text email;
	public Text password;
	// Use this for initialization
	void Start () 
	{
		connection.Connect ("192.168.1.100", 2000);
		ServerEvents.AddEvent ("CustomEvent");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnApplicationQuit()
	{
		connection.CloseConnection ();
	}

	public void SignUp()
	{
		AccountDataBase.CreateAccount (useraname.text, email.text, password.text);
	}

	public void Login()
	{
		AccountDataBase.ValidateAccount (useraname.text, password.text);
	}

	public void CreateAvatar()
	{
		AvatarDatabase.AddAvatar ();
	}

	public void SaveAvatar()
	{
		AvatarDatabase.SaveAvatar ();
	}
}
