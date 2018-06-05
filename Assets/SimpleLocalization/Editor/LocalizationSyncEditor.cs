using UnityEditor;
using UnityEngine;

namespace Assets.SimpleLocalization.Editor
{
	/// <summary>
	/// Adds "Sync" button to LocalizationSync script.
	/// </summary>
	[CustomEditor(typeof(LocalizationSync))]
    public class LocalizationSyncEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            var localizationDownloader = (LocalizationSync) target;

            if (GUILayout.Button("Sync"))
            {
	            localizationDownloader.Download();
            }
		}
    }
}