using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Builder
{
    public static void BuildProject()
    {
        string[] defaultScene = { "Assets/Scenes/MainScene.unity" };

        BuildPipeline.BuildPlayer(defaultScene, "C:/Users/james/Desktop/Builds/Game.exe", BuildTarget.StandaloneWindows64, BuildOptions.None);

    }
}
