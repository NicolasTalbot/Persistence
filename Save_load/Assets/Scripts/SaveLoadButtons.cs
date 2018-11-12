using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadButtons : MonoBehaviour {

	public void Save()
    {
        GameController.control.SaveGame();
        SceneController.sceneControl.SaveActiveScene();
    }

    public void Load()
    {
        GameController.control.LoadGame();
        SceneController.sceneControl.LoadActiveScene();
    }
}
