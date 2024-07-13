using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class Builder : MonoBehaviour
{
    static void BuildWebGL()
    {
        var arguments = Environment.GetCommandLineArgs();
        var destinationDirectoryPath = arguments[1];
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = EditorBuildSettings.scenes.Where(scene => scene.enabled)
            .Select(scene => scene.path).ToArray();
        buildPlayerOptions.locationPathName = destinationDirectoryPath;
        buildPlayerOptions.target = BuildTarget.WebGL;
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}