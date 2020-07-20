using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

public class LoadScript : MonoBehaviour
{
    public string assetBundlePath;
    public string addressableLoadLabel;
    public void LoadAssetBundleAndCreate()
    {
        AssetBundle ab = AssetBundle.LoadFromFile(System.IO.Path.Combine(Application.streamingAssetsPath, assetBundlePath));
        GameObject cube = GameObject.Instantiate(ab.LoadAsset<GameObject>("Cube"), transform);
    }

    public void AddressableLoadAndCreate()
    {
        Addressables.LoadAssetAsync<GameObject>(addressableLoadLabel).Completed += handle =>
        {
            GameObject.Instantiate(handle.Result, transform);
        };
    }
}
